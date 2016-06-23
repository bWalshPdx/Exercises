using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Sorting
{
    [TestFixture]
    public class InsertionSortPart2_Tests
    {
        //TODO: Write a test to verify the print out from hackrank tests:
        [TestCase(0, 5, 100)]
        public void InsertionSort_MatchesOracle(int start, int count, int testIterations)
        {
            InsertionSortPart2 insSort = new InsertionSortPart2();

            var range = Enumerable.Range(start, count);
            var oracle = SortOracle<int>.ForInsertSort1(range, false);

            var input = oracle.UnSortedSourceCollection;

            var output = insSort.Sort(input, true);

            Assert.AreEqual(oracle.SortedList, output);
        }

        [TestCase("0 2 3 4 1", "0 1 2 3 4")]
        [TestCase("0 6 5 1 2 4 3", "0 1 2 3 4 5 6")]
        public void shiftElements_returnsInOrder(string arrayInput, string arrayExpectedOutput)
        {
            InsertionSortPart2 insSort = new InsertionSortPart2();

            var output = insSort.Sort(arrayInput);
            int[] expectedOutput = arrayExpectedOutput.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("1 4 3 5 6 2", "1 2 3 4 5 6")]
        public void InsertionSortPart2_ArrayIsSorted(string unSortedInput, string sortedInput)
        {
            List<int> expectedOutput = sortedInput.Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            InsertionSortPart2 insSort = new InsertionSortPart2();

            var output = insSort.Sort(unSortedInput);

            Assert.AreEqual(expectedOutput, output);

        }

    //Sample Input
    //9
    //9 8 6 7 3 5 4 1 2
    
    //Sample Output
    
    //8 9 6 7 3 5 4 1 2
    //6 8 9 7 3 5 4 1 2
    //6 7 8 9 3 5 4 1 2
    //3 6 7 8 9 5 4 1 2
    //3 5 6 7 8 9 4 1 2
    //3 4 5 6 7 8 9 1 2
    //1 3 4 5 6 7 8 9 2
    //1 2 3 4 5 6 7 8 9 
    

        //TODO: <NA> Refactor to get this and the above test to work:
        [Test]
        public void InsertionSortPart2_IterationOracleMatches_Test1()
        {
            var input = "9 8 6 7 3 5 4 1 2".Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            string expectedOutput = "8 9 6 7 3 5 4 1 2" + Environment.NewLine +
                                    "6 8 9 7 3 5 4 1 2" + Environment.NewLine +
                                    "6 7 8 9 3 5 4 1 2" + Environment.NewLine +
                                    "3 6 7 8 9 5 4 1 2" + Environment.NewLine +
                                    "3 5 6 7 8 9 4 1 2" + Environment.NewLine +
                                    "3 4 5 6 7 8 9 1 2" + Environment.NewLine +
                                    "1 3 4 5 6 7 8 9 2" + Environment.NewLine +
                                    "1 2 3 4 5 6 7 8 9" + Environment.NewLine;

            InsertionSortPart2 insSort = new InsertionSortPart2();

            var output = insSort.Sort(input, true);

            Console.Write(insSort.IterationLog.ToString());
            Console.WriteLine("------Expected Output------");
            Console.Write(expectedOutput);

            Assert.AreEqual(expectedOutput, insSort.IterationLog.ToString());
        }

        [Test]
        public void InsertionSortPart2_IterationOracleMatches_Test2()
        {
            var input = "1 4 3 5 6 2".Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            string expectedOutput = "1 4 3 5 6 2" + Environment.NewLine +
                                    "1 3 4 5 6 2" + Environment.NewLine +
                                    "1 3 4 5 6 2" + Environment.NewLine +
                                    "1 3 4 5 6 2" + Environment.NewLine +
                                    "1 2 3 4 5 6" + Environment.NewLine;

            InsertionSortPart2 insSort = new InsertionSortPart2();

            var output = insSort.Sort(input, true);

            Console.Write(insSort.IterationLog.ToString());
            Console.WriteLine("------Expected Output------");
            Console.Write(expectedOutput);

            Assert.AreEqual(expectedOutput, insSort.IterationLog.ToString());
        }


        [TestCase(5, 1, "1 4 3 5 6 2", "1 2 4 3 5 6")]
        [TestCase(5, 0, "1 4 3 5 6 2", "2 1 4 3 5 6")]
        [TestCase(0, 5, "1 4 3 5 6 2", "4 3 5 6 2 1")]
        public void insertElement_IntegrationTest(int insertFrom, int insertInto, string rawInput, string rawExpectedOutput)
        {
            List<int> input = rawInput.Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            List<int> expectedOutput = rawExpectedOutput.Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            InsertionSortPart2 insPart2 = new InsertionSortPart2();

            insPart2.insertElement(input, insertFrom, insertInto);

            Assert.AreEqual(expectedOutput, input);
        }

    }
}
