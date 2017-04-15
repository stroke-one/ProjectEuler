namespace ProjectEuler.Support
{
    public class GenPrimes
    {

        public byte[] GetPrimes(long maxPrimeNumber)
        {
            var primes = new byte[maxPrimeNumber + 1];

            for (long i = 2; i < maxPrimeNumber; i++)
            {
                if (primes[i] == 0)
                {
                    primes[i] = 1;
                    for (long j = 2; j <= (maxPrimeNumber / i); j++)
                    {
                        primes[i * j] = 2;
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

