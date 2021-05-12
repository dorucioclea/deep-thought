namespace ProblemCozümleri.ProjectEuler
{
    public class Problem02
    {
        public static int EvenFibonacciNumbers(int fibLimit)
        {
            int firstFib = 0;
            int secondFib = 1;
            int sumEvenValFib = 0;

            while (secondFib < fibLimit)
            {
                int tempSecondFib = secondFib;
                secondFib += firstFib;
                firstFib = tempSecondFib;
                if (secondFib % 2 == 0)
                    sumEvenValFib += secondFib;
            }

            return sumEvenValFib;
        }
    }
}