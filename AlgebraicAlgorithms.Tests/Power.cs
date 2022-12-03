namespace AlgebraicAlgorithms.Tests
{
    public class Power
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(2, 10), 1024.0);
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(123456789, 0), 1.0);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(1.001, 1000), 11), 2.71692393224);
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(1.0001, 10000), 11), 2.71814592682);
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(1.00001, 100000), 11, 
                MidpointRounding.ToNegativeInfinity), 2.71826823719);
        }
        [Test]
        public void Test5()
        {
            Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(1.000001, 1000000), 10, 
                MidpointRounding.ToNegativeInfinity), 2.7182804691);
        }
        [Test]
        public void Test6()
        {
            Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(1.0000001, 10000000), 7,
                MidpointRounding.ToNegativeInfinity), 2.7182816);
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionBinaryAlgorithmPower(1.00000001, 100000000), 7,
                MidpointRounding.ToNegativeInfinity), 2.7182817);
        }
        [Test]
        public void Test8()
        {
            //Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionPow(1.000000001, 1000000000), 7,
               // MidpointRounding.ToNegativeInfinity), 2.7182820);
        }
        [Test]
        public void Test9()
        {
            //Assert.AreEqual(Math.Round(AlgebraicAlgorithms.Power.DecompositionPow(1.0000000001, 10000000000), 7,
               // MidpointRounding.ToNegativeInfinity), 2.7182820);
        }
    }
}