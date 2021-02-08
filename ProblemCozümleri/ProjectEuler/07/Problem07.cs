using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem07
    {
        public static int Prime10001st(int maxNumber)
        {
            int numberOfPrime = 1;
            int prime = 1;

            while (numberOfPrime < maxNumber)
            {
                prime += 1;
                if (PrimeHelpers.IsPrimeNumber(prime))
                    numberOfPrime += 1;
            }

            return prime;
        }
    }
}