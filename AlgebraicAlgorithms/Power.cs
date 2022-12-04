using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms
{
    static public class Power
    {
        /// <summary>
        /// Алгоритм возведения в степень через двоичное разложение показателя степени O(2LogN) = O(LogN)
        /// </summary>
        public static double DecompositionBinaryAlgorithmPower(double number, long exponent)
        {
            long d = 1;
            double outVal = 1;

            while (exponent > 1)
            {
                exponent /= 2;
                d *= 2;
                if (exponent % 2 != 0)
                {
                    outVal = outVal * Pow(number, d);
                }
            }
            return outVal;
        }

        /// <summary>
        /// Алгоритм возведения в степень через домножение O(N/2+LogN) = O(N)
        /// </summary>
        public static double MultiplicationAlgorithmPower(double number, long exponent)
        {
            //находим ближайшее число степени двойки к показателю степени. Переменная ExponentMultipleTwo - ближайшая степень двойки.
            long binaryShift = 2;
            long ExponentMultipleTwo = 0;
            while (binaryShift < exponent)
            {
                ExponentMultipleTwo = exponent & binaryShift;
                binaryShift = binaryShift << 1;
            }

           return BrutalPow(number, exponent - ExponentMultipleTwo) * Pow(number, ExponentMultipleTwo);
        }

        /// <summary>
        /// Возводит число в степень двойки
        /// </summary>
        /// <param name="number"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        static double Pow(double number, long exp)
        {
            while (exp >= 2)
            {
                exp = exp / 2;
                number *= number;
                //использую рекурсию
                Pow(number, exp);
            }
            return number;
        }
        /// <summary>
        ///Возводит число в указанную степень 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        static double BrutalPow(double number, long exp)
        {
            double result = 1;
            while (exp >= 1)
            {
                result *= number;
                exp--;
            }
            return result;
        }


    }
}
