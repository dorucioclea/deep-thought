using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem40
    {
        public static long ChampernowneConstant()
        {
            long result = 1;
            int d = 1;
            int number = 0;
            int sumLength = 0;
            while (d <= 1000000)
            {
                number++;

                int IntLength = MathHelpers.IntLength(number);
                sumLength += IntLength;
                if (sumLength >= d)
                {
                    int index = (d - sumLength + IntLength) - 1;
                    var digitNumber = MathHelpers.GetDigitInsideNumber(number, index);
                    result *= digitNumber;
                    d = d * 10;
                }

            }

            return result;
        }
    }
}