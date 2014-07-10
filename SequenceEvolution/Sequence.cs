using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEvolution
{
    public class Sequence
    {
        private List<Nucleotyde> values = new List<Nucleotyde>();

        public Sequence()
        {

        }

        public Sequence(string s)
        {
            foreach (char c in s.ToLower())
            {
                switch (c)
                {
                    case 'a':
                        values.Add(Nucleotyde.A);
                        break;
                    case 'g':
                        values.Add(Nucleotyde.G);
                        break;
                    case 'c':
                        values.Add(Nucleotyde.C);
                        break;
                    case 't':
                        values.Add(Nucleotyde.T);
                        break;
                    default:
                        break;
                }
                
            }
        }

        public Nucleotyde this[int key]
        {
            get
            {
                return values.ElementAt(key);
            }
            set
            {
                values[key] = value;
            }
        }

        public int Length()
        {
            return values.Count();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Nucleotyde n in values)
            {
                sb.Append(ConvertToString(n));
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public string ConvertToString(Nucleotyde n)
        {
            switch (n)
            {
                case Nucleotyde.A:
                    return "a";
                case Nucleotyde.G:
                    return "g";
                case Nucleotyde.C:
                    return "c";
                case Nucleotyde.T:
                    return "t";
                default:
                    throw new Exception("unnknown nucleotyde type");
            }
        }

        public void AppendNucleotyde(Nucleotyde n)
        {
            values.Add(n);
        }
    }
}
