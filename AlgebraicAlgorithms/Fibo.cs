using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms
{
    public static class Fibo
    {
        /// <summary>
        /// Алгоритм поиска чисел Фибоначчи по формуле золотого сечения
        /// </summary>
        public static UInt64 GetByGolden(int n)
        {
            double f = (1 + Math.Pow(5, 0.5)) / 2;

            return (UInt64)((Math.Pow(f, n) / Math.Pow(5, 0.5)) + 0.5);
        }

        /// <summary>
        /// Алгоритм поиска чисел Фибоначчи O(LogN) через умножение матриц
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static BigInteger GetByMatrix(int n)
        {
            BigInteger[,] startMatrix = new BigInteger[,] { { 1, 1 },
                                              { 1, 0 } };

            return Matrix.DecompositionBinaryAlgorithmPower(startMatrix, n - 1)[0,0];
        }
    }
}
