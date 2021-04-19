using System.Collections.Generic;
using System.Numerics;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem25
    {
        public static int Digit1000FibonacciNumber()
        {
            BigInteger firstFib = 1;
            BigInteger secondFib = 1;

            int f = 3;
            while (true)
            {
                BigInteger fn = BigInteger.Add(firstFib, secondFib);
                if (fn.ToString().Length == 1000) break;

                firstFib = secondFib;
                secondFib = fn;
                f++;
            }

            return f;
        }
    }
}