using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms
{
    public class Eratosthen
    {
        public static long GetCountPrime(long n)
        {
            long[] numbers = new long[n];
            long[] primes = new long[(n / 2) + 1];

            long count = 0;
            while (count < n)
            {
                numbers[count] = ++count;
            }

            long p = 0;
            long numberCount = 1;
            var sqrt = Math.Sqrt(n);
            while (numberCount < sqrt)
            {
                p = numbers[numberCount++];
                if (p > 0)
                {
                    count = 1;
                    while (count < ((n / p)))
                    {
                        numbers[(p * ++count) - 1] = 0;
                    }
                }
            }

            numberCount = 0;
            long primeCount = 0;
            while (++numberCount < n)
            {
                if (numbers[numberCount] > 0)
                {
                    primes[primeCount++] = numbers[numberCount];
                }
            }
            return primeCount;
        }
    }
}
