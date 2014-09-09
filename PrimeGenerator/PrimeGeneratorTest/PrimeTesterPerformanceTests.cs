using System;
using System.Diagnostics;
using NUnit.Framework;
using PrimeGenerator;

namespace PrimeGeneratorTest
{
    [TestFixture]
    public class PrimeTesterPerformanceTests
    {
        readonly PrimeTester _primeTester = new PrimeTester();

        [Test]
        public void Given1ThroughOneHundredThousandWhenGetPrimesThenShowPerformance()
        {
            var timer = new Stopwatch();
            timer.Start();

            var primes = _primeTester.GetPrimes(1, 100000);
            foreach (var prime in primes)
            {
                timer.Stop();
                Console.WriteLine("Time: {0} Number: {1}", timer.ElapsedMilliseconds, prime);
                timer.Reset();
                timer.Start();
            }
        }
    }
}
