using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms
{
    public static class Primes
    {
        /// <summary>
        /// Алгоритм поиска простых чисел с оптимизациями поиска и делением только на простые числа, O(N * Sqrt(N) / Ln (N))
        /// </summary>
        /// <returns></returns>
        public static long GetCountPrime(long n)
        {
            if (n < 2)
                return 0;

            long[] primes = new long[(n/2) + 1];
            primes[0] = 2;

            long number = 3;
            long count = 1;
            while (number <= n)
            {
                if (IsPrime(number, primes))
                {
                    primes[count++] = number;
                }
                number++;
            }
            return count;
        }

        static bool IsPrime(long n, long[] primes)
        {
            var sqrt = Math.Sqrt(n);

            long count = 0;
            while (primes[count] <= sqrt)
            {
                if(n % primes[count++] == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
