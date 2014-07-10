using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEvolution
{
    //allready in Kimura Model
    public class ProbabilityMatrix
    {
        private double alpha;
        private double beta;
        private int t;
        private double[,] matrixValues = new double[4, 4];//matrix is indexed as [Row_index, Col_index]
        public const int MATRIX_SIZE = 4;
        public ProbabilityMatrix(double alpha, double beta)
        {
            if (beta >= alpha)
            {
                throw new ArgumentException("parametr beta nie moze byc wiekszy niz parametr alpha");
            }
            else
            {
                this.alpha = alpha;
                this.beta = beta;
            }            
        }

        public void setTime(double time)
        {
            double st = (1.0 - Math.Pow(Math.E, -4.0 * beta * time)) / 4.0;  // (1 - e^(-4BT))/4
            double ut = (1.0 + Math.Pow(Math.E, -4.0 * beta * time) - 2.0 * Math.Pow(Math.E, -2.0 * (alpha + beta) * time)) / 4.0; // (1 + e^(-4BT) - 2e^(-2(A+B)T))/4
            double rt = 1.0 - 2 * st - ut; // 1 - 2st - ut
            setMatrixValues(st, ut, rt);
        }

        private void setMatrixValues(double st, double ut, double rt)
        {
            matrixValues[0, 0] = matrixValues[1, 1] = matrixValues[2, 2] = matrixValues[3, 3] = rt;
            matrixValues[0, 1] = matrixValues[1, 0] = matrixValues[2, 3] = matrixValues[3, 2] = st;
            matrixValues[1, 2] = matrixValues[2, 1] = matrixValues[0, 3] = matrixValues[3, 0] = st;
            matrixValues[3, 1] = matrixValues[2, 0] = matrixValues[1, 3] = matrixValues[0, 2] = ut;
            //checkMatrixValues(matrixValues);
        }

        private void checkMatrixValues(double[,] matrixValues)
        {
            for (int r = 0; r < matrixValues.GetLength(0); r++)
            {
                double columnSum = 0.0;
                for (int c = 0; c < matrixValues.GetLength(1); c++)
                {
                    columnSum += matrixValues[r, c];
                }
                if (columnSum != 1.0)
                {
                    throw new Exception("wartości powinny sie sumować do 1.0");
                }
            }

            for (int c = 0; c < matrixValues.GetLength(1); c++)
            {
                double rowSum = 0.0;
                for (int r = 0; r < matrixValues.GetLength(0); r++)
                {
                    rowSum += matrixValues[r, c];
                }
                if (rowSum != 1.0)
                {
                    throw new Exception("wartości powinny sie sumować do 1.0");
                }
            }
        }

        public double this[int row, int col]
        {
            get
            {
                return matrixValues[row, col];
            }
        }

        public double this[char aIndex, char bIndex]
        {
            get
            {
                return matrixValues[charToIntIndex(aIndex), charToIntIndex(bIndex)];
            }
        }

        public double this[Nucleotyde first, Nucleotyde second]
        {
            get
            {
                return matrixValues[(int)first, (int)second];
            }
        }

        public int charToIntIndex(char c)
        {
            //Good To know that default sequence order is AGCT
            switch (c)
	        {
                case 'a':
                    return 0;
                case 'g':
                    return 1;
                case 'c':
                    return 2;
                case 't':
                    return 3;
		        default:
                    return -1;
	        }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int row = 0; row < MATRIX_SIZE; row++)
            {
                sb.Append("( ");
                for (int col = 0; col < MATRIX_SIZE; col++)
                {
                    sb.Append(this[row, col].ToString());
                    sb.Append(" ");
                }
                sb.Append(")");
            }
            sb.Append("]");
            return sb.ToString();
        }

    }
}
