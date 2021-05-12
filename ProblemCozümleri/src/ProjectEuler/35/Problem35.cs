using System;
using System.Collections.Generic;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem35
    {
        public static long CircularPrimes()
        {

            int circularPrimesCount = 0;
            for (var i = 0; i < 1000000; i++)
            {
                if (PrimeHelpers.IsPrimeNumber(i))
                {

                    if (IsCricularPrimes(i)) circularPrimesCount++;
                }
            }

            return circularPrimesCount;
        }

        static bool IsCricularPrimes(int primeNumber)
        {
            int circularNumber = MathHelpers.GetNextCircularNumber(primeNumber);

            while (circularNumber != primeNumber)
            {
                if (!PrimeHelpers.IsPrimeNumber(circularNumber))
                    return false;

                circularNumber = MathHelpers.GetNextCircularNumber(circularNumber);
            }

            return true;
        }
    }
}