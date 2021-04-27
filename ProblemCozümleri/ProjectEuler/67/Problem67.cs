using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem67
    {
        public static int MaximumPathSumII()
        {

            List<int[]> readAllLines = ReadAllLines();

            for (var i = readAllLines.Count - 2; i >= 0; i--)
            {
                for (var j = 0; j <= i; j++)
                {
                    readAllLines[i][j] += Math.Max(readAllLines[i + 1][j], readAllLines[i + 1][j + 1]);
                }
                readAllLines.RemoveAt(i + 1);
            }

            return readAllLines[0][0];
        }

        static List<int[]> ReadAllLines()
        {
            List<int[]> allLines = new List<int[]>();

            string[] numbersStr = File.ReadAllLines(@"./ProjectEuler/67/triangle.txt");
            for (var i = 0; i < numbersStr.Length; i++)
            {
                int[] lineNumbers = numbersStr[i].Split(' ').Select(x => int.Parse(x)).ToArray();
                allLines.Add(lineNumbers);
            }

            return allLines;
        }
    }
}