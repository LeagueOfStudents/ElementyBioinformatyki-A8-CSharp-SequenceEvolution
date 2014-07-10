using SequenceEvolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode = 2;
            try
            {
                float transitionRate = 0.3f;
                float transversionRate = 0.2f;
                //Sequence human = new Sequence("TGGTCCTGCTGTCCTCTCCTGGCGCCCTGGGCGCGAGCGGATGT");
                //Sequence chimpansee = new Sequence("TGATCCTGCAGTCCTTGGGCGCGACTGGGCGCGTGCGGTTGTCC");
                Sequence human =        new Sequence("TGGTCCTGCTGTCCTCTCCTGGCGCCCTGGGCGCGAGCGGATGT");
                Sequence chimpansee =   new Sequence("TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT");
            Console.WriteLine("PART 1");
                double time = DnaEvolution.ComputeMostPropTime(aSeq: human, bSeq: chimpansee, alpha: transitionRate, beta: transversionRate);
                Console.WriteLine(time);
            Console.WriteLine("PART 2");
                double inputTime = time;
                Sequence inputSequence = human;
                Console.WriteLine(inputSequence);
                for (int i = 0; i < 10; i++)
                {
                    Sequence outputSequence = DnaEvolution.ComputeMostPropabSequenceAfterTime(inputSequence, inputTime, transitionRate, transversionRate, null);
                    Console.WriteLine(outputSequence);
                }
                Console.WriteLine("- should: - be licke -");
                Console.WriteLine(chimpansee);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
