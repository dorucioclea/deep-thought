using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem18
    {
        public static int MaximumPathSumI()
        {

            List<List<int>> readAllLines = FileHelpers.GetTwoDimensionArrayByTextFile("18", "triangle");

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