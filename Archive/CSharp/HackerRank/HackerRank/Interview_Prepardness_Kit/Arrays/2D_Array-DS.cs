using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Interview_Prepardness_Kit.Arrays
{
    //Reference:
    //https://www.hackerrank.com/challenges/2d-array/problem?h_l=playlist&slugs%5B%5D=interview&slugs%5B%5D=interview-preparation-kit&slugs%5B%5D=arrays
    public class TwoDimArrayDS
    {
        public List<int[]> Get2DArray(int[][] input, int width = 6)
        {
            var output = new List<int[]>();

            for (int i = 0; i < width; i++)
            {
                int[] currentRecord = new int[6];

                for (int j = 0; j < width; j++)
                {
                    currentRecord[j] = input[i][j];
                }

                output.Add(currentRecord);
            }

            return output;
        }
        
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
                output.Add(new int[] {0,0,0});
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

        public int GetHigestValue(int[][] input)
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
