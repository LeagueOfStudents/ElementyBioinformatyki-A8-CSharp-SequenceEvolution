using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEvolution
{
    public static class DnaEvolution
    {
        private static int endTimeParamRange = 100;

        public static int EndTimeParamRange
        {
            set { DnaEvolution.endTimeParamRange = value; }
        }

        /*
         *  alpha - transition rate
         *  beta  - transversion rate
         */

        public static double ComputeMostPropTime(Sequence aSeq, Sequence bSeq, double alpha, double beta, double timeIncrement = 0.01)
        {
            if (aSeq.Length() != bSeq.Length())
            {
                throw new ArgumentException("sekwencje muszą mieć tą samą długość");
            }
            else if (alpha < beta )
            {
                throw new AggregateException("parametry alpha beta powinny spelniać zalerzność B <= A");
            }

            //wszystkie wartości obliczonych prawdopodobieństw dla wszystkich parametrow t
            List<TimePropabilitiy> timePropabilities = new List<TimePropabilitiy>();

            // struktura pomagajaca znaleźć maksymalne podobieństwo
            MaxPropability maxPropability = new MaxPropability();

            // Macierz model ewolucji
            ProbabilityMatrix probMatrix = new ProbabilityMatrix(alpha, beta);

            //iteracja po czasie
            for (double currentTime = 0.0; currentTime < endTimeParamRange; currentTime += timeIncrement)
            {
                // macierz jest zależna od t, zmieniając t zmieniamy wszystkie jej wartości
                probMatrix.setTime(currentTime);
                double prop = 1.0;
                for (int i = 0; i < aSeq.Length(); i++)
                {
                    Nucleotyde first = aSeq[i];
                    Nucleotyde second = bSeq[i];
                    prop *= probMatrix[first, second]; // * pi(b)
                }
                timePropabilities.Add(new TimePropabilitiy(currentTime, prop));
            }

            foreach (TimePropabilitiy x in timePropabilities)
            {
                Console.WriteLine(x);    
            }
            
            maxPropability.FindMaxPropability(timePropabilities);

            return maxPropability.Time;
        }

        public static double ComputeMostPropTimeMethodTwo(Sequence aSeq, Sequence bSeq, double alpha, double beta, double timeIncrement = 0.01)
        {
            if (aSeq.Length() != bSeq.Length())
            {
                throw new ArgumentException("sekwencje muszą mieć tą samą długość");
            }
            else if (alpha < beta)
            {
                throw new AggregateException("parametry alpha beta powinny spelniać zalerzność B <= A");
            }

            List<TimePropabilitiy> timePropabilities = new List<TimePropabilitiy>();

            MaxPropability maxPropability = new MaxPropability();

            //1. Macierz model ewolucji
            ProbabilityMatrix probMatrix = new ProbabilityMatrix(alpha, beta);

            for (double currentTime = 0.0; currentTime < endTimeParamRange; currentTime += timeIncrement)
            {
                // macierz jest zależna od t, zmieniając t zmieniamy wszystkie jej wartości
                probMatrix.setTime(currentTime);
                double probability = 1.0;
                for (int i = 0; i < aSeq.Length(); i++)
                {
                    Nucleotyde first = aSeq[i];
                    Nucleotyde second = bSeq[i];
                    // podejście z przodkiem wyliczanie prawdopodobieństwa zmiany nukleotydu przodka na nukleotyd z A lub nukleotyd z B
                    foreach (Nucleotyde ancestor in EnumUtil.GetAllPossibleValues<Nucleotyde>())
                    {
                        probability *= probMatrix[ancestor, first] * probMatrix[ancestor, second];
                    }
                }
                timePropabilities.Add(new TimePropabilitiy(currentTime, probability));
            }

            foreach (TimePropabilitiy x in timePropabilities)
            {
                Console.WriteLine(x);
            }

            maxPropability.FindMaxPropability(timePropabilities);

            return maxPropability.Time;
        }

        public static Sequence ComputeMostPropabSequenceAfterTime(Sequence aSeq, double time, double alpha, double beta, int? predefinedSeed = null)
        {
            if (aSeq == null || aSeq.Length() == 0)
            {
                throw new ArgumentException("należy podać sekwencję bazową");
            }
            else if (alpha < beta)
            {
                throw new AggregateException("parametry alpha beta powinny spelniać zalerzność B <= A");
            }

            ProbabilityMatrix probMatrix = new ProbabilityMatrix(alpha, beta);
            probMatrix.setTime(time);   // macierz modelu ewolucji jest parametryzowana od podanego czasu

            //ustawienie przedzialow losowania dzieki ktorym otrzymujemy wartości losowe o proporcjach z probMatrix
            TransformRanges a = new TransformRanges(probMatrix['a', 'a'], probMatrix['a', 'g'], probMatrix['a', 'c'], probMatrix['a', 't']);
            TransformRanges g = new TransformRanges(probMatrix['g', 'a'], probMatrix['g', 'g'], probMatrix['g', 'c'], probMatrix['g', 't']);
            TransformRanges c = new TransformRanges(probMatrix['c', 'a'], probMatrix['c', 'g'], probMatrix['c', 'c'], probMatrix['c', 't']);
            TransformRanges t = new TransformRanges(probMatrix['t', 'a'], probMatrix['t', 'g'], probMatrix['t', 'c'], probMatrix['t', 't']);

            //losowana jest wartość z przedzialu (0,1)
            Random rand = (predefinedSeed.HasValue) ? new Random(predefinedSeed.Value) : new Random();
            Sequence result = new Sequence();

            for (int i = 0; i < aSeq.Length(); i++)
            {
                double drawnNumber = rand.NextDouble();
                switch (aSeq[i])  // wybór rzędu z macierzy lub wybór przedziału losowania na podstawie nukleotydu z sekwencji A
                {
                    //dopisywanie wylosowanych nukleotydów do sekwencji wynikowej
                    case Nucleotyde.A:
                        result.AppendNucleotyde(a.Transform(drawnNumber));
                        break;
                    case Nucleotyde.G:
                        result.AppendNucleotyde(g.Transform(drawnNumber));
                        break;
                    case Nucleotyde.C:
                        result.AppendNucleotyde(c.Transform(drawnNumber));
                        break;
                    case Nucleotyde.T:
                        result.AppendNucleotyde(t.Transform(drawnNumber));
                        break;
                    default:
                        break;
                }                
            }
            return result;
        }
    }
}
