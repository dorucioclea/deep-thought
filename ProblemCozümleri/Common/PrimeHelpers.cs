using System;

namespace ProblemCozümleri.Common
{
    public class PrimeHelpers
    {
        public static bool IsPrimeNumber(int n)
        {
            for (int i = 2; i < Math.Pow(n, 0.5) + 1; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}