using System;
using System.IO;
using System.Linq;

namespace ProblemCozümleri.ProjectEuler
{
    public static class Problem22
    {
        public static long NamesScores(string path)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string namesText = File.ReadAllText(path);
            string[] namesList = namesText.Replace("\"", string.Empty).Split(",").OrderBy(x => x).ToArray();

            int totalNameScore = 0;
            for (var i = 0; i < namesList.Length; i++)
            {
                int nameScore = 0;
                for (int j = 0; j < namesList[i].Length; j++)
                {
                    nameScore += Array.IndexOf(alphabet, namesList[i][j]) + 1;
                }

                totalNameScore += nameScore * (i + 1);
            }

            return totalNameScore;
        }
    }
}