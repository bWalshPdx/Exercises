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
        [Fact]
        public void Convert_ShouldReturnItself()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int input = 1;
            string expectedOutput = "1";

            string output = fizzBuzz.Convert(input);

            Assert.Equal(expectedOutput, output);

        }
    }
}
