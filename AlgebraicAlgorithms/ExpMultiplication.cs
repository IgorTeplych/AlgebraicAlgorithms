using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms
{
    static public class ExpMultiplication
    {
        /// <summary>
        /// Через степень двойки с домножением
        /// </summary>
        public static double DecompositionPow(double number, int exponent)
        {
            int d = 1;
            double outVal = 1;

            while (exponent > 1)
            {
                exponent /= 2;
                d *= 2;
                if (exponent % 2 != 0)
                {
                    outVal *= Pow(number, d);
                }
            }
            return outVal;
        }
        static double Pow(double number, int exp)
        {
            while (exp >= 2)
            {
                exp = exp / 2;
                number *= number;
                Pow(number, exp);
            }
            return number;
        }

    }
}
