using System;
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
    }
}
