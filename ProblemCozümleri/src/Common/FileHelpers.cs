using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProblemCozümleri.Common
{
    public static class FileHelpers
    {
        public static List<List<int>> GetTwoDimensionArrayByTextFile(string problemNo, string fileName)
        {
            List<List<int>> allLines = new List<List<int>>();

            string path = string.Format("./ProjectEuler/{0}/{1}.txt", problemNo, fileName);
            string[] numbersStr = File.ReadAllLines(path);
            for (var i = 0; i < numbersStr.Length; i++)
            {
                List<int> lineNumbers = numbersStr[i].Split(' ').Select(x => int.Parse(x)).ToList();
                allLines.Add(lineNumbers);
            }

            return allLines;
        }
    }
}