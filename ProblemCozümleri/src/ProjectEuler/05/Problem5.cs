namespace ProblemCozümleri.ProjectEuler
{
    public class Problem5
    {
        public static int SmallestMultiple()
        {
            int number = 1;
            while (true)
            {
                bool isWhileBreak = true;
                for (int i = 1; i <= 20; i++)
                {
                    if (number % i != 0)
                    {
                        number++;
                        isWhileBreak = false;
                        break;
                    }
                }

                if (isWhileBreak) break;
            }

            return number;
        }
    }
}