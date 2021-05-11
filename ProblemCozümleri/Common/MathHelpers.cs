using System;
using System.Numerics;

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

        /// <summary>
        /// String olarak alınan değerin palindrome sayı olup olmadığını döner.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string str)
        {
            string reverseStr = string.Empty;
            for (var i = str.Length - 1; i >= 0; i--)
                reverseStr += str[i];


            return str == reverseStr;
        }

        /// <summary>
        /// BigInteger olarak alınan değerin rakamlarının toplamını döner.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static long SumOfNumbers(BigInteger numbers)
        {
            long sum = 0;
            while (numbers > 0)
            {
                sum += (int)(numbers % 10);
                numbers /= 10;
            }

            return sum;
        }

        /// <summary>
        /// Alınan değerin bir sonraki dairesel sayı değerini döndürür. İlk basamaktaki değeri son basamak yapar.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int GetNextCircularNumber(int number)
        {
            int multiplier = (int)Math.Pow(10, IntLength(number) - 1);
            return (number % 10) * multiplier + number / 10;
        }

        /// <summary>
        /// Integer olarak alınan değerin uzunluğunu döndürür.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int IntLength(int i)
        {
            if (i == 0)
                return 1;
            return (int)Math.Floor(Math.Log10(i)) + 1;
        }
    }
}