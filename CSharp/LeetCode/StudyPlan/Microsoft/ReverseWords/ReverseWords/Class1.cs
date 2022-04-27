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
    }

    public class Solution_Tests
    {
        [Fact]
        public void Bootstrap()
        {
            Solution s = new Solution();

            string output = s.ReverseWords("");

            output.Should().Be("");
        }
    }
}