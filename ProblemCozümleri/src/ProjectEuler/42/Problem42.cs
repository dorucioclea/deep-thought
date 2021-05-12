using System;
using System.IO;
using System.Text.RegularExpressions;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem42
    {
        public static int CodedTriangleNumbers(string path)
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string words = File.ReadAllText(path);
            string[] wordList = words.Split(",");

            int countTriangleNumber=0;
            foreach (var word in wordList)
            {
                int wordLetterValueSum = 0;
                string cleanWord = Regex.Replace(word, "[^A-Za-z0-9 ]", "");
                for (int i = 0; i < cleanWord.Length; i++)
                {
                    wordLetterValueSum += Array.FindIndex(alphabet, x => x == cleanWord[i]) + 1;
                }

                var triangleNumberValue = MathHelpers.GetTirangleNumber(wordLetterValueSum);
                if(triangleNumberValue == Math.Floor(triangleNumberValue)) countTriangleNumber++;
            }

            return countTriangleNumber;
        }

    }
}