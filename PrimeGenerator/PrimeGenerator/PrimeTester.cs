using System.Collections.Generic;

namespace PrimeGenerator
{
    public class PrimeTester
    {
        public bool IsPrime(int number)
        {
            if (number < 2) return false;

            bool numberIsPrime = true;
            for (int i = 2; i < number; ++i)
            {
                if (number % i == 0)
                    numberIsPrime = false;
            }
            return numberIsPrime;
        }

        public IEnumerable<int> GetPrimes(int lowerBound, int upperBound)
        {
            var primes = new List<int>();
            for (int i = lowerBound; i <= upperBound; ++i)
            {
                if(IsPrime(i))
                    primes.Add(i);
            }
            return primes;
        }
    }
}
