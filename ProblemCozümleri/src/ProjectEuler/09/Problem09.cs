using System;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem09
    {
        public static int SpecialPythagoreanTriplet()
        {
            int productSum = 0;
            int number = 1000;
            bool isBreak = false;

            for (var a = 1; a < number / 3; a++)
            {
                for (var b = a; b < number / 2; b++)
                {
                    int c = number - a - b;
                    int aPow = a * a;
                    int bPow = b * b;
                    int cPow = c * c;

                    if (aPow + bPow == cPow)
                    {
                        isBreak = true;
                        productSum = a * b * c;
                        break;
                    }
                }

                if (isBreak) break;
            }

            return productSum;
        }
    }
}