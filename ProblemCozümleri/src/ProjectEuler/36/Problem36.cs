using System;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem36
    {
        public static long DoubleBasePalindromes()
        {
            long sumTwoBasePalindrome = 0;
            for (var i = 0; i < 1000000; i++)
            {
                if (MathHelpers.IsPalindrome(i))
                {
                    string binaryI = Convert.ToString(i, 2);
                    if (MathHelpers.IsPalindrome(binaryI)) sumTwoBasePalindrome += i;
                }
            }

            return sumTwoBasePalindrome;

        }
    }
}