using System;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem19
    {
        public static int CountingSundays()
        {
            DateTime startDate = new DateTime(1901, 1, 1);
            DateTime endDate = new DateTime(2000, 12, 31);

            int sundayCount = 0;
            while (startDate < endDate)
            {
                if (startDate.DayOfWeek == DayOfWeek.Sunday) sundayCount++;

                startDate = startDate.AddMonths(1);
            }

            return sundayCount;
        }
    }
}