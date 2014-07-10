using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceEvolution
{
    public class TimePropabilitiy
    {
        double time;

        public double Time
        {
            get { return time; }
            set { time = value; }
        }
        double propability;

        public double Propability
        {
            get { return propability; }
            set { propability = value; }
        }

        public TimePropabilitiy(double time, double prop)
        {
            this.time = time;
            this.propability = prop;
        }

        public override string ToString()
        {
            return "czas: " + time + "prawdopodobienstwo: " + propability;
        }
    }
}
