using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEvolution
{
    public enum Nucleotyde
    {
        A = 0,
        G = 1,
        C = 2,
        T = 3
    }

    public static class EnumUtil
    {
        public static IEnumerable<T> GetAllPossibleValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
