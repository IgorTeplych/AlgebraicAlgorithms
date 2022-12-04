using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgebraicAlgorithms.Tests
{
    public class Primes
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(10), 4);
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(1), 0);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(2), 1);
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(3), 2);
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(4), 2);
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(5), 3);
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(100), 25);
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(1000), 168);
        }
        [Test]
        public void Test8()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(10000), 1229);
        }
        [Test]
        public void Test9()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(100000), 9592);
        }
        [Test]
        public void Test10()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(1000000), 78498);
        }
        [Test]
        public void Test11()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(10000000), 664579);
        }
        [Test]
        public void Test12()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(100000000), 5761455);
        }
        //[Test]
        public void Test13()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(1000000000), 50847534);
        }
        [Test]
        public void Test14()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Primes.GetCountPrime(123456789), 7027260);
        }
    }
}
