using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEvolution
{
    public class MaxPropability
    {
        double maxValue;
        public double Value
        {
            get { return maxValue; }
        }

        double time;
        public double Time
        {
            get { return time; }
        }
        public MaxPropability()
        {
            maxValue = double.MinValue;
            time = -1;
        }

        public void FindMaxPropability(List<TimePropabilitiy> timePropabilities)
        {
            foreach (TimePropabilitiy x in timePropabilities)
            {
                if (x.Propability > maxValue)
                {
                    maxValue = x.Propability;
                    time = x.Time;
                }
            }
        }
    }
}
