using NUnit.Framework;
using PrimeGenerator;

namespace PrimeGeneratorTest
{
    [TestFixture]
    public class PrimeTesterTest
    {
        PrimeTester _primeTester = new PrimeTester();

        [Test]
        public void Given0WhenIsPrimeShouldReturnFalse()
        {
            bool isPrime = _primeTester.IsPrime(0);
            Assert.IsFalse(isPrime);
        }

        [Test]
        public void Given1WhenIsPrimeShouldReturnTrue()
        {
            bool isPrime = _primeTester.IsPrime(1);
            Assert.IsFalse(isPrime);
        }

        [Test]
        public void Given2WhenIsPrimeShouldReturnTrue()
        {
            bool isPrime = _primeTester.IsPrime(2);
            Assert.IsTrue(isPrime);
        }

        [Test]
        public void Given4WhenIsPrimeShouldReturnFalse()
        {
            bool isPrime = _primeTester.IsPrime(4);
            Assert.IsFalse(isPrime);
        }

        [Test]
        public void Given911WhenIsPrimeShouldReturnTrue()
        {
            bool isPrime = _primeTester.IsPrime(911);
            Assert.IsTrue(isPrime);
        }
    }
}
