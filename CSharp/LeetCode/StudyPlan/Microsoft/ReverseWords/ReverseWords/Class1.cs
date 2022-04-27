using FluentAssertions;
using Xunit;

namespace ReverseWords
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            return "";
        }

        public string[] Splitter(string s)
        {
            string[] output;
            output = s.Split(' ');
            output = output.Where(o => o != "").ToArray();

            return output;
        }
    }

    public class Solution_Tests
    {
        //[Fact]
        //public void Bootstrap()
        //{
        //    Solution s = new Solution();

        //    string output = s.ReverseWords("");

        //    output.Should().Be("");
        //}

        [Fact]
        public void Splitter_CanHandleMultiLeadingSpaces()
        {
            Solution s = new Solution();

            string[] output = s.Splitter("   i");

            output.Length.Should().Be(1);
            output[0].Should().Be("i");
        }

    }
}