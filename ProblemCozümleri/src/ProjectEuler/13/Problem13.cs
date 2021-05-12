using System;
using System.IO;
using System.Numerics;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem13
    {
        public static double LargeSum(string path)
        {
            BigInteger bigSum = 0;

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
                bigSum += BigInteger.Parse(line);

            return Convert.ToDouble(bigSum.ToString().Substring(0, 10));
        }
    }
}