using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEvolution
{
    public class TransformRanges
    {
        double[] ranges = new double[4];

        public TransformRanges(double a, double b, double c, double d)
        {
            ranges[0] = a;
            ranges[1] = a + b;
            ranges[2] = a + b + c;
        }

        public Nucleotyde Transform(double randomValue)
        {
            if (randomValue < 0.0 || randomValue > 1.0)
            {
                throw new ArgumentOutOfRangeException("parametr wylosowany powinien być pomiędzy wartościami <0, 1>");
            }

            if (randomValue <= ranges[0])
            {
                return Nucleotyde.A;
            }
            else if (randomValue <= ranges[1])
            {
                return Nucleotyde.G;
            }
            else if (randomValue <= ranges[2])
            {
                return Nucleotyde.C;
            }
            else 
	        {
                return Nucleotyde.T;
	        }            
        }
    }
}
