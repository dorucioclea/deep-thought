using System.Numerics;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem16
    {
        public static long PowerDigitSum()
        {

            long result = 0;
            BigInteger number = BigInteger.Pow(2, 1000);

            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
            }

            return result;
        }
    }
}