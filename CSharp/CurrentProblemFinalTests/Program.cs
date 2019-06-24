using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentProblemFinalTests
{
    class Solution
    {

        // Complete the hourglassSum function below.

        static void Main(string[] args)
        {
            System.Environment.SetEnvironmentVariable("OUTPUT_PATH", @"C:\Users\datab\Dropbox\1.5 - Inbox\Temp_HackerRank");
            string path = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
            TextWriter textWriter = new StreamWriter(path, true);

            var doit = new TwoDimArrayDS();

            int result = doit.GetHigestValue(Console.ReadLine());

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    public class TwoDimArrayDS
    {
        //public int GetHigestValue(int[] input)
        //{
        //    return 19;
        //}

        //Convert a array of ints into a 6x6 two dimensional array of ints:

        public List<int[]> Get2DArray(string input, int width = 6)
        {
            List<int[]> output = new List<int[]>();
            string[] seperators = new string[] { "\r\n", "\n"};

            string[] lines = input.Split(seperators, StringSplitOptions.None);

            lines = lines.Select(l => l.TrimStart(' ')).ToArray();

            List<int[]> converted = lines.Select(l => l.Split(' ').Select(s => Convert.ToInt32(s)).ToArray()).ToList();
            
            return converted;
        }

        //Take a 3x3 array and return the sum of the 'I' formation:

        //Take a 6x6 array and return a collection of 16 3x3 arrays:


        public List<List<int[]>> Get3x3Arrays(List<int[]> input)
        {
            List<List<int[]>> output = new List<List<int[]>>();
            int xAxis = 1;
            int yAxis = 1;

            int xStartIndex = xAxis;
            int xEndIndex = xAxis + 3;

            int yStartIndex = yAxis;
            int yEndIndex = yAxis + 3;

            int currentIndexToGrab = 0;

            for (int x = xStartIndex; x <= xEndIndex; x++)
            {
                for (int y = yStartIndex; y <= yEndIndex; y++)
                {
                    output.Add(Get3x3Array(input, x, y));
                }
            }

            return output;
        }

        public List<int[]> Get3x3Array(List<int[]> totalArray, int xAxis, int yAxis)
        {
            int smallBoxWidth = 3;
            int totalElementToGrab = 9;

            List<int[]> output = new List<int[]>();

            for (int i = 0; i < smallBoxWidth; i++)
            {
                output.Add(new int[] { 0, 0, 0 });
            }

            int xStartIndex = xAxis - 1;
            int xEndIndex = xAxis + 1;

            int yStartIndex = yAxis - 1;
            int yEndIndex = yAxis + 1;

            int currentIndexToGrab = 0;

            for (int x = xStartIndex; x <= xEndIndex; x++)
            {

                for (int y = yStartIndex; y <= yEndIndex; y++)
                {
                    if (currentIndexToGrab >= totalElementToGrab)
                        return output;

                    var indexesToUpdate = GetXandYAxis(smallBoxWidth, currentIndexToGrab);
                    output[indexesToUpdate.Item1][indexesToUpdate.Item2] = totalArray[x][y];
                    currentIndexToGrab++;
                }
            }

            return output;
        }

        public Tuple<int, int> GetXandYAxis(int width, int indexBeingConverted)
        {
            int currentIndex = 0;
            int endIteration = width - 1;

            for (int x = 0; x <= endIteration; x++)
            {
                for (int y = 0; y <= endIteration; y++)
                {
                    if (currentIndex == indexBeingConverted)
                    {
                        return new Tuple<int, int>(x, y);
                    }

                    currentIndex++;
                }
            }

            throw new Exception("'GetXandYAxis': should have returned by now");
        }

        public int[] GetIFormation(List<int[]> input)
        {
            List<int> output = new List<int>();

            foreach (var i in input[0])
                output.Add(i);

            output.Add(input[1][1]);

            foreach (var i in input[2])
                output.Add(i);

            return output.ToArray();
        }

        public int GetHigestValue(string input)
        {
            List<int[]> twoDArray = Get2DArray(input);

            List<List<int[]>> allArrays = Get3x3Arrays(twoDArray);

            List<int> totals = allArrays
                .Select(GetIFormation)
                .Select(a => a.Sum()).ToList();

            int largest = totals.OrderByDescending(a => a).First();

            return largest;
        }
    }

}