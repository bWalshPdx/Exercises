
using System;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Xunit;

namespace Binary_Search
{
    public class Solution {
        public int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
            }

            return -1;
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
        
        [Fact]
        public async Task Search_GivenTwoElements_ShouldReturnCorrectIndex()
        {
            Solution solution = new Solution();
            int[] input = new int[] {5,9};
            int target = 9;

            int output = solution.Search(input, target);

            output.Should().Be(1);
        }
        
        [Fact]
        public async Task Search_GivenTargetNotFound_ShouldReturnNegativeOne()
        {
            Solution solution = new Solution();
            int[] input = new int[] {5,9};
            int target = 0;

            int output = solution.Search(input, target);

            output.Should().Be(-1);
        }
    }

    
}