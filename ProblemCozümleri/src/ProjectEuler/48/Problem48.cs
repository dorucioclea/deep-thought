using System;
using System.Numerics;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem48
    {
        public static long SelfPowers()
        {
            
            BigInteger result = 0;
            BigInteger mod = BigInteger.Pow(10, 10);

            for (var i = 1; i <= 1000; i++)
            {
                result += BigInteger.ModPow(i, i, mod);
                result %= mod;
            }

            return (long)result;
        }
    }
}