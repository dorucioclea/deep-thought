using System;
using System.Collections.Generic;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem03
    {
        public static long longLargestPrimeFactor()
        {
            long number = 600851475143;
            long lastPrime = 1;
            long largestPrimeNumber = 0;
            
            while (lastPrime <= Math.Sqrt(number))
            {
                if (number % lastPrime == 0 && lastPrime > largestPrimeNumber) largestPrimeNumber = lastPrime;

                lastPrime = PrimeHelpers.GetNextPrime(lastPrime);
            }

            return largestPrimeNumber;
        }
    }
}