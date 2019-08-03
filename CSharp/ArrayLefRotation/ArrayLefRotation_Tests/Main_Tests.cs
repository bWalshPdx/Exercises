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
            Main main = new Main();
            int limit = 5;
            int[] expectedOutput = new[] {1, 2, 3, 4, 5};

            int[] output = main.Generate(limit);

            output.Should().Equal(expectedOutput);
        }

        //should be given 1 and it will return '1'
        [Fact]
        public void Generator_ShouldReturnOneElement()
        {
            Main main = new Main();
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
            Main main = new Main();
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
            Main main = new Main();
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
            Main main = new Main();
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
            Main main = new Main();
            int limit = 3;
            int shiftPos = 2;
            int[] expectedOutput = new[] { 3, 2, 1 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }


        //should be given a 3 with a rotation of 2 and it will return '3 2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftFour()
        {
            Main main = new Main();
            int limit = 5;
            int shiftPos = 4;
            int[] expectedOutput = { 5, 1, 2, 3, 4 };

            int[] output = main.ShiftLeft(limit, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        [Theory]
        [InlineDataAttribute(5, 1, 4, 3)]
        [InlineDataAttribute(5, 1, 1, 4)]
        public void GetShiftedIndex(int arrayLength, int shiftNumber, int originalIndex, int expectedIndex)
        {
            Main main = new Main();

            int output = main.GetShiftedIndex(arrayLength, shiftNumber, originalIndex);

            output.Should().Be(expectedIndex);
        }

        

        #endregion
    }
}
