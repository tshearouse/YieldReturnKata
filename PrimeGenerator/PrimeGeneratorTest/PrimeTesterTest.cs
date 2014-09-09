using System.Linq;
using NUnit.Framework;
using PrimeGenerator;

namespace PrimeGeneratorTest
{
    [TestFixture]
    public class PrimeTesterTest
    {
        readonly PrimeTester _primeTester = new PrimeTester();

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

        [Test]
        public void Given8Through10WhenGetPrimesShouldReturnEmptyList()
        {
            var primes = _primeTester.GetPrimes(8, 10);
            Assert.IsEmpty(primes);
        }

        [Test]
        public void Given10Through15WhenGetPrimesShouldReturn11And13()
        {
            var primes = _primeTester.GetPrimes(10, 15);

            Assert.AreEqual(2, primes.Count());
            Assert.AreEqual(11, primes.First());
            Assert.AreEqual(13, primes.Last());
        }
    }
}
