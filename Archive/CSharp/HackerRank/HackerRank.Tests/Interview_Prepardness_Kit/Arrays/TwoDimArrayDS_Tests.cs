using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Interview_Prepardness_Kit.Arrays;
using Xunit;

namespace HackerRank.Tests.Interview_Prepardness_Kit.Arrays
{
    //http://hamidmosalla.com/2017/02/25/xunit-theory-working-with-inlinedata-memberdata-classdata/
    public class TestDataGenerator : IEnumerable<int[]>
    {
        //public static IEnumerable<int[]> GetHighestValue()
        //{
        //    yield return new int[]{"1 1 1 0 0 0 0 1 0 0 0 0 1 1 1 0 0 0 0 0 2 4 4 0 0 0 0 2 0 0 0 0 1 2 4 0", "19"};
        //}

        public static IEnumerable<object[]> Get2dArray()
        {
            int[][] input = new int[][]
            {
                new int[]{ 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 }
            };
        
            List<int[]> output = new List<int[]>();

            output.Add(new int[]{ 1, 1, 1, 0, 0, 0 });
            output.Add(new int[]{ 0, 1, 0, 0, 0, 0 });
            output.Add(new int[]{ 1, 1, 1, 0, 0, 0 });
            output.Add(new int[]{ 0, 0, 2, 4, 4, 0 });
            output.Add(new int[]{ 0, 0, 0, 2, 0, 0 });
            output.Add(new int[]{ 0, 0, 1, 2, 4, 0 });
            
            yield return new object[] { input, output };
        }

        public static IEnumerable<object[]> GetSixteen3X3Arrays()
        {
            List<int[]> output = new List<int[]>()
            {
                new int[]{3, 0, 0, 0},
                new int[]{3, 8, 2, 2},
                new int[]{3, 5, 1, 2},
                new int[]{2, 0, 0, 0},
                new int[]{2, 2, 1, 0},
                new int[]{2, 1, 0, 1},
                new int[]{2, 3, 1, 1}
            };



            List<int[]> totalArray = new List<int[]> {
                new int[] {1, 2, 3, 4, 5, 6},
                new int[] {7, 8, 9, 10, 11, 12},
                new int[] {13, 14, 15, 16, 17, 18},
                new int[] {19, 20, 21, 22, 23, 24},
                new int[] {25, 26, 27, 28, 29, 30},
                new int[] {31, 32, 33, 34, 35, 36}
            };

            //Returns Sixteen different 3x3 Arrays:
            
            List<int[]> first = new List<int[]>
                {
                    new int[]{
                        1, 2, 3
                    },
                    new int[]{
                       7, 8, 9
                    },
                    new int[]{
                        13, 14, 15
                    }
                };

            List<int[]> second = new List<int[]>
            {
                new int[]{
                    2, 3, 4
                },
                new int[]{
                    8, 9, 10
                },
                new int[]{
                    14, 15, 16
                }
            };

            List<int[]> third = new List<int[]>
            {
                new int[]{
                    3, 4, 5
                },
                new int[]{
                    9, 10, 11
                },
                new int[]{
                    15, 16, 17
                }
            };

            List<int[]> fourth = new List<int[]>
            {
                new int[]{
                    4, 5, 6
                },
                new int[]{
                    10, 11, 12
                },
                new int[]{
                    16, 17, 18
                }
            };

            List<int[]> fifth = new List<int[]>
            {
                new int[]{
                    7, 8, 9
                },
                new int[]{
                    13, 14, 15
                },
                new int[]{
                    19, 20, 21
                }
            };

            List<int[]> sixth = new List<int[]>
            {
                new int[]{
                    8, 9, 10
                },
                new int[]{
                    14, 15, 16
                },
                new int[]{
                    20, 21, 22
                }
            };

            List<int[]> seventh = new List<int[]>
            {
                new int[]{
                    9, 10, 11
                },
                new int[]{
                     15, 16, 17
                },
                new int[]{
                     21, 22, 23
                }
            };

            List<int[]> eigth = new List<int[]>
            {
                new int[]{
                    10, 11, 12
                },
                new int[]{
                    16, 17, 18
                },
                new int[]{
                    22, 23, 24
                }
            };

            List<int[]> ninth = new List<int[]>
            {
                new int[]{
                    1, 1, 1
                },
                new int[]{
                    0, 0, 2
                },
                new int[]{
                    0, 0, 0
                }
            };

            List<int[]> tenth = new List<int[]>
            {
                new int[]{
                    1, 1, 0
                },
                new int[]{
                    0, 2, 4
                },
                new int[]{
                    0, 0, 2
                }
            };

            List<int[]> eleventh = new List<int[]>
            {
                new int[]{
                    1, 0, 0
                },
                new int[]{
                    2, 4, 4
                },
                new int[]{
                    0, 2, 0
                }
            };

            List<int[]> twelth = new List<int[]>
            {
                new int[]{
                    0, 0, 0
                },
                new int[]{
                    4, 4, 0
                },
                new int[]{
                    2, 0, 0
                }
            };


            List<int[]> thirteenth = new List<int[]>
            {
                new int[]{
                    0, 0, 2
                },
                new int[]{
                    0, 0, 0
                },
                new int[]{
                    0, 0, 1
                }
            };

            List<int[]> fourteenth = new List<int[]>
            {
                new int[]{
                    0, 0, 2
                },
                new int[]{
                    0, 0, 0
                },
                new int[]{
                    0, 0, 1
                }
            };

            List<int[]> fifteenth = new List<int[]>
            {
                new int[]{
                    0, 2, 4
                },
                new int[]{
                    0, 0, 2
                },
                new int[]{
                    0, 1, 2
                }
            };

            List<int[]> sixteenth = new List<int[]>
            {
                new int[]{
                    4, 4, 0
                },
                new int[]{
                    2, 0, 0
                },
                new int[]{
                    2, 4, 0
                }
            };

            List<List<int[]>> expectedOutputCollection = new List<List<int[]>>(){first, second, third, fourth, fifth, sixth, seventh,
                eigth, ninth, tenth, eleventh, twelth, thirteenth, fourteenth, fifteenth, sixteenth};

            yield return new object[]{ totalArray, expectedOutputCollection};

        }

        public static IEnumerable<object[]> GetSingle3X3Array()
        {
            int xAxisOfArray = 1;
            int yAxisOfArray = 4;

            List<int[]> totalArray = new List<int[]> {
                new int[]{
                    1, 2, 3, 4, 5, 6
                },
                new int[]{
                    7, 8, 9, 10, 11, 12
                },
                new int[]{
                    13, 14, 15, 16, 17, 18
                },
                new int[]{
                    19, 20, 21, 22, 23, 24
                },
                new int[]{
                    25, 26, 27, 28, 29, 30
                },
                new int[]{
                    31, 32, 33, 34, 35, 36
                }
            };

            List<int[]> smallArrayToBeReturned = new List<int[]>
            {
                new int[]{
                    4, 5, 6
                },
                new int[]{
                    10, 11, 12
                },
                new int[]{
                    16, 17, 18
                }
            };

            yield return new object[] { totalArray, xAxisOfArray, yAxisOfArray, smallArrayToBeReturned };

            //More straightforward test:
            int xAxisOfArray_2 = 1;
            int yAxisOfArray_2 = 1;

            List<int[]> totalArray_2 = new List<int[]> {
                new int[]{
                    1, 2, 3, 4, 5, 6
                },
                new int[]{
                    7, 8, 9, 10, 11, 12                },
                new int[]{
                    13, 14, 15, 16, 17, 18
                },
                new int[]{
                    19, 20, 21, 22, 23, 24
                },
                new int[]{
                    25, 26, 27, 28, 29, 30
                },
                new int[]{
                    31, 32, 33, 34, 35, 36
                }
            };

            List<int[]> smallArrayToBeReturned_2 = new List<int[]>
            {
                new int[]{
                    1, 2, 3
                },
                new int[]{
                    7, 8, 9
                },
                new int[]{
                    13, 14, 15
                }
            };

            yield return new object[] { totalArray_2, xAxisOfArray_2, yAxisOfArray_2, smallArrayToBeReturned_2 };

            //More straightforward test:
            int xAxisOfArray_3 = 4;
            int yAxisOfArray_3 = 4;
            
            List<int[]> totalArray_3 = new List<int[]> {
                new int[]{
                    1, 2, 3, 4, 5, 6
                },
                new int[]{
                    7, 8, 9, 10, 11, 12
                },
                new int[]{
                    13, 14, 15, 16, 17, 18
                },
                new int[]{
                    19, 20, 21, 22, 23, 24
                },
                new int[]{
                    25, 26, 27, 28, 29, 30
                },
                new int[]{
                    31, 32, 33, 34, 35, 36
                }
            };

            List<int[]> smallArrayToBeReturned_3 = new List<int[]>
            {
                new int[]{
                    22, 23, 24
                },
                new int[]{
                    28, 29, 30
                },
                new int[]{
                    34, 35, 36
                }
            };

            yield return new object[] { totalArray_3, xAxisOfArray_3, yAxisOfArray_3, smallArrayToBeReturned_3 };
        }

        public static List<object[]> GetXandYCoords()
        {
            //width, currentIndex, expectedXAxis, expectedYAxis:
            List<object[]> output = new List<object[]>()
            {
                new object[]{3, 0, 0, 0},
                new object[]{3, 8, 2, 2},
                new object[]{3, 5, 1, 2},
                new object[]{2, 0, 0, 0},
                new object[]{2, 2, 1, 0},
                new object[]{2, 1, 0, 1},
                new object[]{2, 3, 1, 1}
            };

            return output;
        }


        public static List<object[]> GetHighestValue()
        {
            int[][] input1 = new int[][]
            {
                new int[]{ 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 }
            };
            //string input1 = @"1 1 1 0 0 0
            //0 1 0 0 0 0
            //1 1 1 0 0 0
            //0 0 2 4 4 0
            //0 0 0 2 0 0
            //0 0 1 2 4 0";

            int expectedOutput1 = 19;


            int[][] input2 = new int[][]
            {
                new int[]{ -9, -9, -9, 1, 1, 1 },
                new int[] { 0, -9, 0, 4, 3, 2 },
                new int[] { -9, -9, -9, 1, 2, 3 },
                new int[] { 0, 0, 8, 6, 6, 0 },
                new int[] { 0, 0, 0, -2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 }
            };

            //string input2 = @"-9 -9 -9 1 1 1
            //0 -9 0 4 3 2
            //-9 -9 -9 1 2 3
            //0 0 8 6 6 0
            //0 0 0 -2 0 0
            //0 0 1 2 4 0";

            int expectedOutput2 = 28;
            
            List<object[]> output = new List<object[]>()
            {
                new object[]{input1, expectedOutput1},
                new object[]{input2, expectedOutput2}
            };

            return output;
        }



        public IEnumerator<int[]> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class TwoDimArrayDS_Tests
    {
        public TwoDimArrayDS classUnderTest;

        public TwoDimArrayDS_Tests()
        {
            classUnderTest = new TwoDimArrayDS();
        }
        
        //Convert a array of ints into a 6x6 two dimensional array of ints:
        [Theory()]
        [MemberData(nameof(TestDataGenerator.Get2dArray), MemberType = typeof(TestDataGenerator))]
        public void Get2DArray_IntegrationTest(int[][] input, List<int[]> expectedOutput)
        {
            List<int[]> output = classUnderTest.Get2DArray(input);
            Assert.Equal(expectedOutput, output);
        }

        //Take a 6x6 array and return a collection of 16 3x3 arrays:
        [Fact()]
        public void Get3x3Arrays_ReturnsTheCorrectNumberOfArrays()
        {
            List<int[]> input = new List<int[]> {
                new int[]{
                    1, 2, 3, 4, 5, 6
                },
                new int[]{
                    7, 8, 9, 10, 11, 12                },
                new int[]{
                    13, 14, 15, 16, 17, 18
                },
                new int[]{
                    19, 20, 21, 22, 23, 24
                },
                new int[]{
                    25, 26, 27, 28, 29, 30
                },
                new int[]{
                    31, 32, 33, 34, 35, 36
                }
            };

            List<List<int[]>> output = classUnderTest.Get3x3Arrays(input);

            Assert.Equal(16, output.Count);
        }

        //Take a multidimensional array and a index and return a 3x3 array:
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetSingle3X3Array), MemberType = typeof(TestDataGenerator))]
        public void Get3x3Array_IntegrationTest(List<int[]> totalArray, int xAxis, int yAxis, List<int[]> expectedOutput)
        {
            List<int[]> output = classUnderTest.Get3x3Array(totalArray, xAxis, yAxis);

            Assert.Equal(expectedOutput, output);
        }
        
        //width, currentIndex, expectedXAxis, expectedYAxis:
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetXandYCoords), MemberType = typeof(TestDataGenerator))]
        public void GetXandYCoords_IntegrationTest(int width, int currentIndex, int exepectedXAxis, int expectedYAxis)
        {
            Tuple<int, int> output = classUnderTest.GetXandYAxis(width, currentIndex);

            Assert.Equal(exepectedXAxis, output.Item1);
            Assert.Equal(expectedYAxis, output.Item2);
        }

        //Take a 3x3 array and return the sum of the 'I' formation:
        [Fact]
        public void GetIFormation_IntegrationTest()
        {
            List<int[]> input = new List<int[]>
            {
                new int[]{
                    22, 23, 24
                },
                new int[]{
                    28, 29, 30
                },
                new int[]{
                    34, 35, 36
                }
            };

            int[] expectedOutput = {22, 23, 24, 29, 34, 35, 36};

            int[] output = classUnderTest.GetIFormation(input);

            Assert.Equal(expectedOutput, output);
        }

        //Take a collection of 3x3 arrays and return the largest sum of the 'I':

        //The final results:
        [Theory]
        [MemberData(nameof(TestDataGenerator.GetHighestValue), MemberType = typeof(TestDataGenerator))]
        public void GetHighestValue_IntegrationTest(int[][] input, int expectedOutput)
        {
            int output = classUnderTest.GetHigestValue(input);

            Assert.Equal(expectedOutput, output);
        }
    }
}
