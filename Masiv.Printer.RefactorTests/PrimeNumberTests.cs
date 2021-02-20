namespace Masiv.Printer.Refactor.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class PrimeNumberTests
    {
        [TestMethod()]
        public void IsPrimeOkTest()
        {
            int numberPrime = 2;
            Assert.IsTrue(numberPrime.IsPrime());
        }

        [TestMethod()]
        public void IsNotPrimeOkTest()
        {
            int numberPrime = 1;
            Assert.IsFalse(numberPrime.IsPrime());
        }
    }
}