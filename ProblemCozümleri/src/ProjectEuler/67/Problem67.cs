using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem67
    {
        public static int MaximumPathSumII(string path)
        {

            List<List<int>> readAllLines = FileHelpers.GetTwoDimensionArrayByTextFile(path);

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
    }
}