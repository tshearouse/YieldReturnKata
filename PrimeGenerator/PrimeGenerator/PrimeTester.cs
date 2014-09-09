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
    }
}
