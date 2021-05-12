using Xunit;
using ProblemCozümleri.ProjectEuler;
using System;

namespace ProblemCozümleri.Tests
{
    public class ProjectEulerTests
    {
        [Fact]
        public void Problem01_Return_Result_233168()
        {
            int act = Problem01.MultiplesOf3And5();

            Assert.True(act.Equals(233168));
        }

        [Fact]
        public void Problem02_Return_Result_4613732()
        {
            int act = Problem02.EvenFibonacciNumbers();

            Assert.True(act.Equals(4613732));
        }

        [Fact]
        public void Problem03_Return_Result_6857()
        {
            long act = Problem03.longLargestPrimeFactor();

            Assert.True(act.Equals(6857));
        }

        [Fact]
        public void Problem04_Return_Result_906609()
        {
            long act = Problem04.LargestPalindromeProduct();

            Assert.True(act.Equals(906609));
        }

        [Fact]
        public void Problem05_Return_Result_232792560()
        {
            int act = Problem05.SmallestMultiple();

            Assert.True(act.Equals(232792560));
        }

        [Fact]
        public void Problem06_Return_Result_25164150()
        {
            double act = Problem06.SumSquareDifference();

            Assert.True(act.Equals(25164150));
        }

        [Fact]
        public void Problem07_Return_Result_104743()
        {
            int act = Problem07.Prime10001st();

            Assert.True(act.Equals(104743));
        }

        [Fact]
        public void Problem08_Return_Result_23514624000()
        {
            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\08\numbers.txt";
            double act = Problem08.LargestProductSeries(path);

            Assert.True(act.Equals(23514624000));
        }

        [Fact]
        public void Problem09_Return_Result_31875000()
        {
            int act = Problem09.SpecialPythagoreanTriplet();

            Assert.True(act.Equals(31875000));
        }

        [Fact]
        public void Problem10_Return_Result_142913828922()
        {
            long act = Problem10.SummationOfPrimes();

            Assert.True(act.Equals(142913828922));
        }

        [Fact]
        public void Problem11_Return_Result_70600674()
        {
            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\11\grid.txt";

            long act = Problem11.LargestProductInAGrid(path);

            Assert.True(act.Equals(70600674));
        }

        [Fact]
        public void Problem12_Return_Result_76576500()
        {
            long act = Problem12.HighlyDivisibleTriangularNumber();

            Assert.True(act.Equals(76576500));
        }

        [Fact]
        public void Problem13_Return_Result_5537376230()
        {

            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\13\numbers.txt";

            double act = Problem13.LargeSum(path);

            Assert.True(act.Equals(5537376230));
        }

        [Fact]
        public void Problem14_Return_Result_837799()
        {
            long act = Problem14.LongestCollatzSequence();

            Assert.True(act.Equals(837799));
        }

        [Fact]
        public void Problem18_Return_Result_1074()
        {
            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\18\triangle.txt";

            int act = Problem18.MaximumPathSumI(path);

            Assert.True(act.Equals(1074));
        }

        [Fact]
        public void Problem19_Return_Result_171()
        {
            int act = Problem19.CountingSundays();

            Assert.True(act.Equals(171));
        }

        [Fact]
        public void Problem20_Return_Result_648()
        {
            long act = Problem20.FactorialDigitSum();

            Assert.True(act.Equals(648));
        }

        [Fact]
        public void Problem22_Return_Result_871198282()
        {

            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\22\p022_names.txt";

            long act = Problem22.NamesScores(path);

            Assert.True(act.Equals(871198282));
        }

        [Fact]
        public void Problem25_Return_Result_4782()
        {
            int act = Problem25.Digit1000FibonacciNumber();

            Assert.True(act.Equals(4782));
        }

        [Fact]
        public void Problem28_Return_Result_669171001()
        {
            long act = Problem28.NumberSpiralDiagonals();

            Assert.True(act.Equals(669171001));
        }

        [Fact]
        public void Problem35_Return_Result_55()
        {
            long act = Problem35.CircularPrimes();

            Assert.True(act.Equals(55));
        }

        [Fact]
        public void Problem36_Return_Result_872187()
        {
            long act = Problem36.DoubleBasePalindromes();

            Assert.True(act.Equals(872187));
        }

        [Fact]
        public void Problem40_Return_Result_210()
        {
            long act = Problem40.ChampernowneConstant();

            Assert.True(act.Equals(210));
        }

        [Fact]
        public void Problem42_Return_Result_162()
        {

            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\42\p042_words.txt";

            int act = Problem42.CodedTriangleNumbers(path);

            Assert.True(act.Equals(162));
        }

        [Fact]
        public void Problem48_Return_Result_9110846700()
        {
            long act = Problem48.SelfPowers();

            Assert.True(act.Equals(9110846700));
        }

        [Fact]
        public void Problem67_Return_Result_7273()
        {

            string basePath = @"c:\repository\deep-thought\ProblemCozümleri\";
            string path = basePath + @"src\ProjectEuler\67\triangle.txt";

            int act = Problem67.MaximumPathSumII(path);

            Assert.True(act.Equals(7273));
        }
    }
}
