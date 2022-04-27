using FluentAssertions;
using Xunit;
using Xunit.Sdk;

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

        public string Reverser(string[] input)
        {
            throw new NotImplementedException();
        }
    }

    public class Solution_Tests
    {
        [Fact]
        public void Splitter_CanHandleMultiLeadingSpaces()
        {
            Solution s = new Solution();

            string[] output = s.Splitter("   i");

            output.Length.Should().Be(1);
            output[0].Should().Be("i");
        }

        [Fact]
        public void Splitter_CanHandleMultiSpacesMidSentence()
        {
            Solution s = new Solution();

            string[] output = s.Splitter("1   2 3");

            output.Length.Should().Be(3);
            output[0].Should().Be("1");
            output[1].Should().Be("2");
            output[2].Should().Be("3");
        }

        [Fact]
        public void Splitter_CanHandleMultiCharactersMidSentence()
        {
            Solution s = new Solution();

            string[] output = s.Splitter("one  two  three");

            output.Length.Should().Be(3);
            output[0].Should().Be("one");
            output[1].Should().Be("two");
            output[2].Should().Be("three");
        }

        [Fact]
        public void Reverser_WillReturnTheSplitReversed()
        {
            Solution s = new Solution();

            string[] input = new[] { "three", "two", "one" };

            string output = s.Reverser(input);

            output.Should().Be("three two one");
        }

    }
}