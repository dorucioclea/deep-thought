using System;

namespace ProblemCozümleri.Common
{
    public class MathHelpers
    {
        public static double ProductOfNumbersInSeries(double n)
        {
            double product = 1;
            while (n != 0)
            {
                product = product * (n % 10);
                n = Math.Floor(n / 10);
            }
            return product;
        }
    }
}