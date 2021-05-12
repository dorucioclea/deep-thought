using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem11
    {
        public static long LargestProductInAGrid()
        {
            List<List<int>> grid = FileHelpers.GetTwoDimensionArrayByTextFile("11", "grid");
            long largestProduct = 0;

            for (var row = 0; row < grid.Count; row++)
            {
                for (var column = 0; column < grid[row].Count; column++)
                {
                    long right = 1;
                    long down = 1;
                    long rightDiagonally = 1;
                    long leftDiagonally = 1;

                    for (var j = 0; j < 4; j++)
                    {
                        if (column <= 16)
                            right *= grid[row][column + j];

                        if (row <= 16)
                            down *= grid[row + j][column];

                        if (column >= 3 && row <= 16)
                            leftDiagonally *= grid[row + j][column - j];

                        if (row <= 16 && column <= 16)
                            rightDiagonally *= grid[row + j][column + j];

                    }

                    if (right > largestProduct) largestProduct = right;
                    if (down > largestProduct) largestProduct = down;
                    if (rightDiagonally > largestProduct) largestProduct = rightDiagonally;
                    if (leftDiagonally > largestProduct) largestProduct = leftDiagonally;
                }
            }

            return largestProduct;
        }
    }
}