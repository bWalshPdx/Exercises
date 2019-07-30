﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLefRotation;
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

            Assert.Equal(expectedOutput, output);
        }

        //should be given 1 and it will return '1'
        [Fact]
        public void Generator_ShouldReturnOneElement()
        {
            Main main = new Main();
            int limit = 1;
            int[] expectedOutput = new[] { 1 };

            int[] output = main.Generate(limit);

            Assert.Equal(expectedOutput, output);
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

            Assert.Equal(expectedOutput, output);
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

            Assert.Equal(expectedOutput, output);
        }

        #endregion
    }
}