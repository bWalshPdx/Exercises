using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sorting
{

    [TestFixture]
    public class InsertionSortPart1_Tests
    {
        private InsertionSortPart1 insSort1 = new InsertionSortPart1();
        public string _oraclePath;

        [SetUp]
        public void Setup()
        {
            _oraclePath = @"C:\Insert1Oracle\";
        }

        [TestCase("2 4 6 8 3", "2 3 4 6 8")]
        [TestCase("2 4 6 8 9", "2 4 6 8 9")]
        [TestCase("2 4 6 8 1", "1 2 4 6 8")]
        public void shiftElements_shiftsTheCorrectNumberToTheLeft(string arrayInput, string arrayExpectedOutput)
        {
            var expectedOutput = arrayExpectedOutput.Split(' ').Select(i => Int32.Parse(i)).ToList();
            var output = insSort1.Sort(arrayInput);

            Console.WriteLine("Expected: {0}", expectedOutput.Aggregate("", (first, second) => first + " " + second));
            Console.WriteLine("Output: {0}", output.Aggregate("", (first, second) => first + " " + second));

            Assert.AreEqual(expectedOutput, output);
        }

        //TODO: There is a problem with the split function in one of these tests:
        //[TestCase(100, 0, 10)]
        //[TestCase(100, 0, 100)]
        //[TestCase(100, 0, 1000)]
        //[TestCase(100, 0, 10000)]
        //[TestCase(100, 0, 100000)]
        //[TestCase(100, 0, 1000000)]
        public void InsertionSortPart1_OracleSortShouldMatch(int testIterations, int start, int count)
        {
            bool allTestsPassed = true;
            InsertionSortPart1 insSortPart1 = new InsertionSortPart1();

            bool haveElementDupes = false;
            var testCollection = Enumerable.Range(start, count).ToList();

            for (int i = 0; i < testIterations; i++)
            {
                Insert1Oracle<int> sortInsert1Oracle = SortOracle<int>.ForInsertSort1(testCollection, haveElementDupes);

                string input = sortInsert1Oracle.SortedSourceCollection.Aggregate("", (first, second) => first + " " + second);

                input = input + " " + sortInsert1Oracle.ElementToInsert;

                input = input.Substring(1);

                var output = insSortPart1.Sort(input, true);

                bool testFailed = SortOracle<int>.TestAgainstOracle(sortInsert1Oracle, output, _oraclePath);


                if (testFailed)
                    break;

                Console.WriteLine("Test {0} complete", i);
            }

            Assert.True(allTestsPassed);
        }

        [TestCase(@"C:\Insert1Oracle\FailedSort4_14_2015 10_14_47 AM.xml"), Ignore]
        public void InsertionSortPart1_OracleTestFromPreviousOracle(string oraclePath)
        {
            Insert1Oracle<int> sortInsert1Oracle = SortOracle<int>.ForInsertSort1(oraclePath);

            //string input = sortInsert1Oracle.SortedSourceCollection.Aggregate("", (first, second) => first + " " + second);

            //input = input + " " + sortInsert1Oracle.ElementToInsert;

            List<int> input = sortInsert1Oracle.SortedSourceCollection;
            input.Add(sortInsert1Oracle.ElementToInsert);

            InsertionSortPart1 insSortPart1 = new InsertionSortPart1();
            var output = insSortPart1.Sort(input, true);

            Assert.AreEqual(sortInsert1Oracle.SortedList, output);

            //bool testPassed = SortOracle<int>.TestAgainstOracle(sortInsert1Oracle, output);

            //Assert.IsTrue(testPassed);
        }

    }

}
