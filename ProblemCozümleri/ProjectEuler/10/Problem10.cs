using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem10
    {
        public static long SummationOfPrimes()
        {
            int number = 2000000;
            long summartionPrimes = 0;
            for (int i = 2; i < number; i++)
            {
                if (PrimeHelpers.IsPrimeNumber(i))
                    summartionPrimes += i;
            }

            return summartionPrimes;
        }
    }
}