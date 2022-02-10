using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace FizzBuzz
{
    public class FizzBuzz_Tests
    {
        [Fact]
        public async Task GetOutput_Given3Inputs_ReturnsFizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<int> input = new List<int>() {1, 2, 3};
            
            string output =  fizzBuzz.GetOutput(input);
            
            Assert.Equal("1 2 Fizz", output);
        }
        
        [Fact]
        public async Task GetOutput_Given4Inputs_ReturnsFizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<int> input = new List<int>() {1, 2, 3, 4};
            
            string output =  fizzBuzz.GetOutput(input);
            
            Assert.True(output == "1 2 Fizz 4");
        }
        
        [Fact]
        public async Task GetOutput_Given4Inputs_ReturnsFizz()
        { 
            FizzBuzz fizzBuzz = new FizzBuzz();
            List<int> input = new List<int>() {1, 2, 3, 4};
            
            string output =  fizzBuzz.GetOutput(input);
            
            Assert.True(output == "1 2 Fizz 4");
        }
    }
    
}
