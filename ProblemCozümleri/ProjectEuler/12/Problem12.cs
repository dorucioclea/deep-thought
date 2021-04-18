using System;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem12
    {
        public static long HighlyDivisibleTriangularNumber()
        {
            long triangleNumber = 0;
            long number = 0;

            while (true)
            {
                number++;
                triangleNumber += number;
                int divisionCount = 0;
                for (var i = 1; i <= Math.Sqrt(triangleNumber); i++)
                {
                    if (triangleNumber % i == 0)
                        divisionCount += 2;
                }

                if (divisionCount >= 500)
                    break;
            }

            return triangleNumber;
        }
    }
}