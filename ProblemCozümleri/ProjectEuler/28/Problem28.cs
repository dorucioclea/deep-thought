namespace ProblemCozümleri.ProjectEuler
{
    public class Problem28
    {
        public static long NumberSpiralDiagonals()
        {

            int sideLenght = 1;
            long sumSquareCorners = 1;

            int lastCorner = 1;
            while (sideLenght < 1001)
            {
                sideLenght += 2;
                for (var i = 0; i < 4; i++)
                {
                    lastCorner += sideLenght - 1;
                    sumSquareCorners += lastCorner;
                }
            }

            return sumSquareCorners;
        }
    }
}