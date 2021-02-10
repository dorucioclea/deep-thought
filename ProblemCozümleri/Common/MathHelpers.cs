using System;

namespace ProblemCozümleri.Common
{
    public class MathHelpers
    {
        /// <summary>
        /// Alınan sayının rakamların çarpımlarını döndürür.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Alınan değerin üçgensel sayı karşılığını döndürür.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double GetTirangleNumber(int number)
        {
            return (Math.Sqrt(1 + (8 * number)) - 1) / 2;

        }

    }
}