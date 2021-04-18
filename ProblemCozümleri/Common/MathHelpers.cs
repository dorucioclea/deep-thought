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

        /// <summary>
        /// Alınan değerin palindrome sayı olup olmadığını döner
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPalindrome(long number)
        {
            long tempNumber = number;
            long reverseNumber = 0;
            while (tempNumber > 0)
            {
                reverseNumber = (reverseNumber * 10) + (tempNumber % 10);
                tempNumber /= 10;
            }

            return reverseNumber == number;

        }
    }
}