namespace ProblemCozümleri.ProjectEuler
{
    public class Problem01
    {
        public static int MultiplesOf3And5()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0) sum += i;

            return sum;

        }

    }
}