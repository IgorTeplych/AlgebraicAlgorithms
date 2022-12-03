namespace AlgebraicAlgorithms.Tests
{
    public class Power
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Num1()
        {
            Assert.AreEqual(AlgebraicAlgorithms.Power.DecompositionPow(2, 10), 1024.0);
        }
    }
}