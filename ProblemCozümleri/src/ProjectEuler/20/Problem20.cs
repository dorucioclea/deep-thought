using System.Numerics;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem20
    {
        public static long FactorialDigitSum()
        {

            BigInteger factProduct = 1;
            int startFact = 100;
            while (startFact > 0)
            {
                factProduct *= startFact;

                startFact--;
            }

            return MathHelpers.SumOfNumbers(factProduct);
        }
    }
}