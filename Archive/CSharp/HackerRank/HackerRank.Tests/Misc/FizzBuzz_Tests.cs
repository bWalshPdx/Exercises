using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Misc;
using Xunit;

namespace HackerRank.Tests.Misc
{
    
    public class FizzBuzz_Tests
    {
        //https://www.hackerrank.com/challenges/fizzbuzz/problem
        /*
         *Tests for FizzBuzz:
         * A value that isn't divisible be 3 or 5 returns itself
         *
         * For each multiple of 3, print "Fizz" instead of the number.
         *
         * For each multiple of 5, print "Buzz" instead of the number.
         *
         * For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
         *
         * Guiding Test:
         * 1 => 1
         * 2 => 2
         * 3 => Fizz
         * 4 => 4
         * 5 => Buzz
         * 6 => Fizz
         * 7 => 7
         * 8 => 8
         * 9 => Fizz
         * 10 => Buzz
         * 11 => 11
         * 12 => Fizz
         * 13 => 13
         * 14 => 14
         * 15 => FizzBuzz
         */

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(11, "11")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        public void InputReturnsItself(int input, string expOutput)
        {
            string output = FizzBuzz.Converter(input);

            Assert.Equal(expOutput, output);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        public void InputReturnsFizz(int input, string expOutput)
        {
            string output = FizzBuzz.Converter(input);

            Assert.Equal(expOutput, output);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void InputReturnsBuzz(int input, string expOutput)
        {
            string output = FizzBuzz.Converter(input);

            Assert.Equal(expOutput, output);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        public void InputReturnsFizzBuzz(int input, string expOutput)
        {
            string output = FizzBuzz.Converter(input);

            Assert.Equal(expOutput, output);
        }

        [Fact]
        public void OutputIsCorrect()
        {
            int start = 1;
            int end = 15;
            string expectedOutput = @"1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz";
            
            string output = FizzBuzz.GetOutput(start, end);
            Assert.Equal(expectedOutput, output );
        }
    }
}
