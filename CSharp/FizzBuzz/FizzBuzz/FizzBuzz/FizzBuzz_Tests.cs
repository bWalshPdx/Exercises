using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace FizzBuzz
{

    [Collection("Root Test")]
    public class FizzBuzz_Tests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void Convert_ShouldReturnItself(int input, string expectedOutput)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            
            string output = fizzBuzz.Convert(input);

            Assert.Equal(expectedOutput, output);

        }


        [Theory]
        [InlineData(3, "Fizz")]
        public void Convert_ShouldReturnFizz(int input, string expectedOutput)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            string output = fizzBuzz.Convert(input);

            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        public void Convert_ShouldReturnBuzz(int input, string expectedOutput)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            string output = fizzBuzz.Convert(input);

            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        public void Convert_ShouldReturnFizzBuzz(int input, string expectedOutput)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            string output = fizzBuzz.Convert(input);

            Assert.Equal(expectedOutput, output);
        }


    }
}
