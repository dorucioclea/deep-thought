using System;

namespace ProblemCozümleri.Common
{
    public class PrimeHelpers
    {
        /// <summary>
        /// Alınan değerin asal sayı olup olmadığı kontrol edilir.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrimeNumber(long n)
        {
            if (n == 2) return true;

            if (n <= 1 || n % 2 == 0) return false;

            int counter = 3;
            while (Math.Pow(counter, 2) <= n)
            {
                if (n % counter == 0)
                    return false;
                else
                    counter += 2;
            }

            return true;
        }

        /// <summary>
        /// Bir sonraki sıradaki asal sayı dönülür.
        /// </summary>
        /// <param name="lastPrime">Asal Sayı</param>
        /// <returns></returns>
        public static long GetNextPrime(long lastPrime)
        {
            for (var i = lastPrime + 1; i < long.MaxValue; i++)
            {
                if (IsPrimeNumber(i)) return i;
            }

            throw new Exception("Bir sonraki Asal Sayı Bulunamadı.");
        }
    }
}