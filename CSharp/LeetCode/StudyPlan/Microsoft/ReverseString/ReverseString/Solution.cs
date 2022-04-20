using FluentAssertions;
using Xunit;

namespace ReverseString
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int arrayCount = s.Length;

            int start = 0;
            int end = arrayCount - 1;

            while (start < end)
            {
                char temp = s[start];

                s[start] = s[end];
                s[end] = temp;

                start++;
                end--;
            }   
        }
    }


    public class Solution_Tests
    {
        [Fact]
        public void ReverseString_MyFact1()
        {
            Solution solution = new Solution();
            char[] input = new[] { 'i' };
            char[] expectedOutput = new[] { 'i' };


            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput, options => options.WithStrictOrdering());
        }
        
        [Fact]
        public void ReverseString_MyFact2()
        {
            Solution solution = new Solution();
            char[] input = new[] { 't', 'o' };
            char[] expectedOutput = new[] { 'o', 't' };


            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput, options => options.WithStrictOrdering());
        }

        [Fact]
        public void ReverseString_MyFact3()
        {
            Solution solution = new Solution();
            char[] input = new[] { 'f', 'o', 'u', 'r' };
            char[] expectedOutput = new[] { 'r', 'u', 'o', 'f' };
            
            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput, options => options.WithStrictOrdering());
        }

        [Fact]
        public void ReverseString_MyFact4()
        {
            Solution solution = new Solution();
            char[] input = new[] { 't', 'w', 'o'};
            char[] expectedOutput = new[] { 'o', 'w', 't' };

            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput, options => options.WithStrictOrdering());
        }


        [Fact]
        public void ReverseString_MyFact5()
        {
            Solution solution = new Solution();
            char[] input = new[] { 'I'};
            char[] expectedOutput = new[] { 'I' };

            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput, options => options.WithStrictOrdering());
        }

        [Fact]
        public void ReverseString_MyFact6()
        {
            Solution solution = new Solution();
            char[] input = { };
            char[] expectedOutput = {};

            solution.ReverseString(input);

            input.Should().BeEquivalentTo(expectedOutput, options => options.WithStrictOrdering());
        }


    }

}