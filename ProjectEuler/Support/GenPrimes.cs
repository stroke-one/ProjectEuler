namespace ProjectEuler.Support
{
    public class GenPrimes
    {

        public bool[] GetPrimes(long maxPrimeNumber)
        {
            // for performance the default all false filled array is used
            // and non-primes are set to true during the sieve
            // this results in tests for prime being logically backwards

            bool[] primes = new bool[maxPrimeNumber + 1];

            for (long i = 2; i < maxPrimeNumber; i++)
            {
                if (primes[i] == false)
                {
                    for (long j = 2; j <= (maxPrimeNumber / i); j++)
                    {
                        primes[i * j] = true;
                    }
                }
            }
            return (primes);
        }


        public bool IsPrime(long testValue)
        {
            for (int i = 2; i < (testValue / 2) + 1; i++)
            {
                if(testValue % i == 0)
                {
                    return (false);
                }
            }
            return (true);
        }
    }
}

