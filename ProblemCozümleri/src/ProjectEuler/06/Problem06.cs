using System;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem06
    {
        public static double SumSquareDifference()
        {
            double squareSum = 0;
            double sumSquare = 0;

            for (int i = 1; i <= 100; i++)
            {
                squareSum += Math.Pow(i, 2);
                sumSquare += i;
            }

            sumSquare = Math.Pow(sumSquare, 2);

            return sumSquare - squareSum;
        }
    }
}