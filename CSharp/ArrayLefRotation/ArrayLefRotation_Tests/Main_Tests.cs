using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLefRotation;
using FluentAssertions;
using Xunit;

namespace ArrayLefRotation_Tests
{
    
    public class Main_Tests
    {
        #region Generator
   
        //should be given 5 and it will return '1 2 3 4 5'
        [Fact]
        public void Generator_ShouldReturnFiveElements()
        {
            Program main = new Program();
            int limit = 5;
            int[] expectedOutput = new[] {1, 2, 3, 4, 5};

            int[] output = main.Generate(limit);

            output.Should().Equal(expectedOutput);
        }

        //should be given 1 and it will return '1'
        [Fact]
        public void Generator_ShouldReturnOneElement()
        {
            Program main = new Program();
            int limit = 1;
            int[] expectedOutput = new[] { 1 };

            int[] output = main.Generate(limit);

            output.Should().Equal(expectedOutput);
        }
        #endregion

        #region ShiftLeft

        //should be given a 1 with rotate 2 and it will return '1':
        [Fact]
        public void ShiftLeft_ShouldShiftOne()
        {
            Program main = new Program();
            int limit = 1;
            int shiftPos = 2;
            int[] expectedOutput = new[] { 1 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        //should be given a 2 with a rotation of 1 and it will return '2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftOneWithTwoElements()
        {
            Program main = new Program();
            int limit = 2;
            int shiftPos = 1;
            int[] expectedOutput = { 2, 1 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        //should be given a 2 with a rotation of 2 and it will return '1 2':
        [Fact]
        public void ShiftLeft_ShouldShiftTwoWithTwoElements()
        {
            Program main = new Program();
            int limit = 2;
            int shiftPos = 2;
            int[] expectedOutput = new[] { 1, 2 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }


        //should be given a 3 with a rotation of 2 and it will return '3 2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftTwo()
        {
            Program main = new Program();
            int limit = 3;
            int shiftPos = 2;
            int[] expectedOutput = new[] { 3, 1, 2 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }


        //should be given a 3 with a rotation of 2 and it will return '3 2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftFour()
        {
            Program main = new Program();
            int limit = 5;
            int shiftPos = 4;
            int[] expectedOutput = { 5, 1, 2, 3, 4 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        #endregion

        #region GetShiftedIndex
        [Theory]
        [InlineDataAttribute(5, 1, 4, 3)]
        [InlineDataAttribute(5, 1, 0, 4)]
        [InlineDataAttribute(5, 1, 3, 2)]
        [InlineDataAttribute(5, 2, 0, 3)]
        public void GetShiftedIndex(int arrayLength, int shiftNumber, int originalIndex, int expectedIndex)
        {
            Program main = new Program();

            int output = main.GetShiftedIndex(arrayLength, shiftNumber, originalIndex);

            output.Should().Be(expectedIndex);
        }
        #endregion


        #region ShiftArray

        [Theory]
        [InlineDataAttribute("5 4", "5 1 2 3 4")]
        public void ShiftArray_ReturnFourShiftedArray(string input, string expectedOutput)
        {
            Program main = new Program();

            string output = main.GetShiftedArray(input);

            output.Should().Be(expectedOutput);
        }
        #endregion


    }
}
