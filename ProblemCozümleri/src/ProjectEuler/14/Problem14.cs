namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem14
    {
        public static long LongestCollatzSequence()
        {
            const int number = 1000000;

            long maxCount = 0;
            long maxStartingNumber = 0;
            long sequenceNumber;

            for (int i = 2; i <= number; i++)
            {
                int count = 1;
                sequenceNumber = i;
                while (sequenceNumber != 1)
                {
                    if (sequenceNumber % 2 == 0)
                        sequenceNumber = sequenceNumber / 2;
                    else
                        sequenceNumber = 3 * sequenceNumber + 1;

                    count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxStartingNumber = i;
                }
            }

            return maxStartingNumber;
        }
    }
}