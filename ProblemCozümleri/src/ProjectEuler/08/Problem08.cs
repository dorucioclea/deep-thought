using System;
using System.IO;
using ProblemCozümleri.Common;

namespace ProblemCozümleri.ProjectEuler
{
    public class Problem08
    {
        public static double LargestProductSeries(string path)
        {
            string numbers = string.Empty;
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
                numbers += line;

            int index = 0;
            double productNumber = 0;
            while (index < numbers.Length && (numbers.Length - index >= 13))
            {
                double n = Convert.ToDouble(numbers.Substring(index, 13));
                double productNumberTemp = MathHelpers.ProductOfNumbersInSeries(n);
                if (productNumberTemp > productNumber)
                    productNumber = productNumberTemp;

                index += 1;
            }

            return productNumber;
        }
    }
}