using System;
using System.Collections.Generic;
using BalancedBrackets;
using FluentAssertions;
using Xunit;

namespace BalancedBrackets_Tests
{
    public class Solution_Tests
    {
        [Fact]
        public void HasMatchingParen_GivenSinglePair_ShouldReturnTrue()
        {
            Solution solution = new Solution();

            char head = '(';
            string tail = ")";

            bool parenMatches = solution.HasMatchingParen(head, tail);

            parenMatches.Should().BeTrue();
        }

        [Fact]
        public void HasMatchingParen_GivenSinglePair_ShouldReturnFalse()
        {
            Solution solution = new Solution();

            char head = '(';
            string tail = "}";

            bool parenMatches = solution.HasMatchingParen(head, tail);

            parenMatches.Should().BeFalse();
        }

        [Fact]
        public void HasMatchingParen_GivenTwoPairs_ShouldReturnTrue()
        {
            Solution solution = new Solution();

            char head = '(';
            string tail = "())";

            bool parenMatches = solution.HasMatchingParen(head, tail);

            parenMatches.Should().BeTrue();
        }

        [Fact]
        public void HasMatchingParen_GivenOuterMismatch_ShouldReturnFalse()
        {
            Solution solution = new Solution();

            char head = '(';
            string tail = "()}";

            bool parenMatches = solution.HasMatchingParen(head, tail);

            parenMatches.Should().BeFalse();
        }

        [Fact]
        public void HasMatchingParen_GivenInnerMismatch_ShouldReturnFalse()
        {
            Solution solution = new Solution();

            char head = '(';
            string tail = "(})";

            bool parenMatches = solution.HasMatchingParen(head, tail);

            parenMatches.Should().BeFalse();
        }


        [Fact]
        public void Solve_GivenFirstGuidingSolution_ShouldReturnCorrectOutput()
        {
            Solution solution = new Solution();

            List<string> input = new List<string>()
            {
                "{{([])}}",
                "{{)[](}}"
            };

            List<string> expectedOutput = new List<string>()
            {
                "YES",
                "NO"
            };


            List<string> output = solution.Solve(input);

            output.Should().BeEquivalentTo(expectedOutput);
        }

    }
}
