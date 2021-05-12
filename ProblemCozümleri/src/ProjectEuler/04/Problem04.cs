using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem04
    {
        public static long LargestPalindromeProduct()
        {
            int firstNumber = 999;
            int secondNumber = 0;
            long maxProductNumber = 0;

            while (firstNumber > 99)
            {
                secondNumber = firstNumber;
                while (secondNumber > 99)
                {
                    long productNumber = firstNumber * secondNumber;
                    if (MathHelpers.IsPalindrome(productNumber))
                    {
                        if (productNumber > maxProductNumber) maxProductNumber = productNumber;
                    }

                    secondNumber--;
                }

                firstNumber--;
            }

            return maxProductNumber;
        }
    }
}