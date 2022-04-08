using FluentAssertions;
using Xunit;

namespace ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {

        }
    }


    public class Solution_Tests
    {
        [Fact]
        public void ReverseString_Fact1()
        {
            Solution solution = new Solution();
            char[] input = new[] { 'i' };
            char[] expectedOutput = new[] { 'i' };


            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput);
        }

    }

}