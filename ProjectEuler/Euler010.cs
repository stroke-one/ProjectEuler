﻿using ProjectEuler.Support;

namespace ProjectEuler
{
    class Euler010
    {
        private long maxValue;

        public Euler010(long maxValue)
        {
            this.maxValue = maxValue;
        }

        public long Solve()
        {
            GenPrimes prime_library = new GenPrimes();
            byte[] primes = prime_library.GetPrimes(this.maxValue);
            long result = 0;
            for(long i=0; i < this.maxValue; i++)
            {
                if (primes[i] == 1)
                {
                    result += i;
                }
                
            }
            return (result);

        }
    }
}
