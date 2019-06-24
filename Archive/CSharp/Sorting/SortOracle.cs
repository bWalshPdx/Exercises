using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sorting
{
    
    public class Insert1Oracle<T>
    {
        public T ElementToInsert;
        public List<T> SortedSourceCollection;
        public List<T> UnSortedSourceCollection;
        public List<T> SortedList;
    }

    public class Insert2Oracle<T>
    {
        public List<T> UnSortedSourceCollection;
        public List<T> SortedList;
    }



    public static class SortOracle<T>
    {
        public static Insert1Oracle<T> ForInsertSort1(IEnumerable<T> seedCollection, bool haveElementDupes)
        {
            T insertElement;
            Random random = new Random();
            var seedCollectionList = seedCollection.ToList();
            
            int index = random.Next(seedCollectionList.Count);
            insertElement = seedCollectionList[index];

            if (!haveElementDupes)
                seedCollectionList.RemoveAt(index);

            var oracle = new Insert1Oracle<T>();

            
            oracle.UnSortedSourceCollection = GetRandomArray(seedCollectionList, haveElementDupes);
            oracle.SortedSourceCollection = oracle.UnSortedSourceCollection.OrderBy(o => o).ToList();
            oracle.ElementToInsert = insertElement;

            var temp = new List<T>();
            temp.AddRange(oracle.SortedSourceCollection);
            temp.Add(insertElement);

            oracle.SortedList = temp.OrderBy(o => o).ToList();

            return oracle;
        }

        public static Insert1Oracle<T> ForInsertSort1(string oraclePath)
        {
            Insert1Oracle<T> insert1Oracle;
            using (FileStream fs = new FileStream(oraclePath, FileMode.Open))
            {
                XmlSerializer xSer = new XmlSerializer(typeof(Insert1Oracle<T>));
                insert1Oracle = (Insert1Oracle<T>)xSer.Deserialize(fs);
            }

            return insert1Oracle;
        }

        public static Insert2Oracle<T> ForInsertSort2(IEnumerable<T> seedCollection, bool haveElementDupes = false)
        {
            Insert2Oracle<T> output = new Insert2Oracle<T>();

            output.UnSortedSourceCollection = GetRandomArray(seedCollection.ToList(), haveElementDupes);
            var minElement = output.UnSortedSourceCollection.Min();
            output.UnSortedSourceCollection.Remove(minElement);
            output.UnSortedSourceCollection.Insert(0, minElement);

            var temp = new List<T>();
            temp.AddRange(output.UnSortedSourceCollection);


            output.SortedList = temp.OrderBy(o => o).ToList();

            return output;
        }

        public static List<T> GetRandomArray(List<T> seedCollection, bool haveElementDupes)
        {
            Random random = new Random();
            List<T> output = new List<T>();
            List<T> listToPullFrom = new List<T>();
            listToPullFrom.AddRange(seedCollection);

            while (true)
            {
                if (output.Count == seedCollection.Count)
                    return output;

                var elementIndex = random.Next(listToPullFrom.Count);

                output.Add(listToPullFrom[elementIndex]);

                if (!haveElementDupes)
                   listToPullFrom.RemoveAt(elementIndex);                
            }
        }

        public static bool TestAgainstOracle(Insert1Oracle<T> insert1Oracle, IEnumerable<T> sequenceUnderTest, string failedOracleSavePath = null)
        {
            var passedTest = sequenceUnderTest.SequenceEqual(insert1Oracle.SortedList);

            if (!passedTest)
            {
                Console.WriteLine("Expected: {0}", insert1Oracle.SortedList.Aggregate("", (first, second) => first + " " + second));
                Console.WriteLine("  Output: {0}", sequenceUnderTest.Aggregate("", (first, second) => first + " " + second));
                Console.WriteLine();

                if (failedOracleSavePath != null)
                    Save(insert1Oracle, failedOracleSavePath);
            }

            return passedTest;
        }

        //http://stackoverflow.com/questions/6115721/how-to-save-restore-serializable-object-to-from-file
        public static void Save(Insert1Oracle<T> insert1Oracle, string failedOracleSavePath)
        {
            DateTime dateTime = DateTime.Now;
            string nowStamp = dateTime.ToString().Replace(':', '_').Replace('/', '_');
            string oraclePath = failedOracleSavePath + "\\" + "FailedSort" + nowStamp + ".xml";

            using (FileStream fs = new FileStream(oraclePath, FileMode.Create))
            {
                XmlSerializer xSer = new XmlSerializer(typeof(Insert1Oracle<T>));

                xSer.Serialize(fs, insert1Oracle);
            }
        }

        

    }

}
