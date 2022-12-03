using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms
{
    internal static class Matrix
    {

        public static BigInteger[,] Multiple(BigInteger[,] matrix1, BigInteger[,] matrix2)
        {
            BigInteger[,] multipleMatrix = new BigInteger[,] { { 0, 0 }, { 0, 0 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        multipleMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return multipleMatrix;
        }

        public static BigInteger[,] DecompositionBinaryAlgorithmPower(BigInteger[,] matrix, long exponent)
        {
            long d = 1;
            BigInteger[,] outMatrix = new BigInteger[,] { { 1, 0 },
                                              { 0, 1 } };

            if ((exponent - 1) % 2 == 0)
                outMatrix = matrix;

            while (exponent > 1)
            {
                exponent /= 2;
                d *= 2;
                if (exponent % 2 != 0)
                {
                    var powMatrix = Pow(matrix, d);
                    outMatrix = Multiple(outMatrix, powMatrix);
                }
            }
            return outMatrix;
        }

        static BigInteger[,] Pow(BigInteger[,] matrix, long exp)
        {
            while (exp >= 2)
            {
                exp = exp / 2;
                matrix = Multiple(matrix, matrix);
                Pow(matrix, exp);
            }
            return matrix;
        }
    }
}
