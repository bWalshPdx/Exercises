using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sorting
{
    [TestFixture]
    public class SortOracle_Tests
    {
        //public string _oraclePath = @"C:\Insert1Oracle\OracleTests";
        //[SetUp]
        //public void SetupOracleTests()
        //{
        //    foreach (var file in Directory.GetFiles(_oraclePath))
        //        File.Delete(file);
        //}

        [Test]
        public void SortOracle_ReturnsDistinctCollection()
        {
            var input = Enumerable.Range(0, 10);
            var allowDupes = false;

            Insert1Oracle<int> insert1Oracle = SortOracle<int>.ForInsertSort1(input, allowDupes);

            var output = insert1Oracle.SortedList.GroupBy(i => i).Any(e => e.Count() > 1);

            Assert.IsFalse(output);
        }

        [Test]
        public void SortOracle_ReturnsCollectionWithDupes()
        {
            var input = Enumerable.Range(0, 10);
            var allowDupes = true;

            Insert1Oracle<int> insert1Oracle = SortOracle<int>.ForInsertSort1(input, allowDupes);

            var output = insert1Oracle.SortedList.GroupBy(i => i).Any(e => e.Count() > 1);

            Assert.IsTrue(output);
        }

        [TestCase("1 5 6 3 2")]
        public void ForInsertPart2_FirstElementIsTheMin(string unSortedInput)
        {
            List<int> expectedInput = unSortedInput.Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            List<int> randomArray = SortOracle<int>.GetRandomArray(expectedInput, false);

            Insert2Oracle<int> output = SortOracle<int>.ForInsertSort2(randomArray);

            Assert.AreEqual(expectedInput, output.UnSortedSourceCollection);
        }

        //[Test]
        //public void ForInsertPart2_OracleCardinatilityIsTheSameAfterDeserialization()
        //{
        //    var range = Enumerable.Range(0, 100);
        //    bool haveElementDupes = true;

        //    Insert1Oracle<int> insert1Oracle = SortOracle<int>.ForInsertSort1(range, haveElementDupes);

        //    //SortOracle<int>.Save(insert1Oracle, _oraclePath);

        //    //var savedOracle = Directory.GetFiles(_oraclePath).First();

        //    //var deserializedOracle = SortOracle<int>.ForInsertSort1(savedOracle);

        //    Assert.AreEqual(insert1Oracle.SortedSourceCollection, deserializedOracle.SortedSourceCollection);
        //    Assert.AreEqual(insert1Oracle.ElementToInsert, deserializedOracle.ElementToInsert);
        //    Assert.AreEqual(insert1Oracle.SortedList, deserializedOracle.SortedList);

        //}

        

    }
}
