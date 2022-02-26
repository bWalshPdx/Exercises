
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Xunit;

namespace Binary_Search
{
    public class Solution {
        public int Search(int[] nums, int target)
        {
            return 0;
        }
    }
    
    public class Solution_Tests
    {
        [Fact]
        public async Task Search_GivenSingleCorrectElement_ShouldReturnCorrectIndex()
        {
            Solution solution = new Solution();
            int[] input = new int[] {9};
            int target = 9;

            int output = solution.Search(input, target);

            output.Should().Be(0);
        }
    }

    
}