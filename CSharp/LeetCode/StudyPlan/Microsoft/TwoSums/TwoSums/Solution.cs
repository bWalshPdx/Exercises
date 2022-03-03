using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace TwoSums
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            throw new ArgumentException();
        }
    }


    public class Solution_Tests
    {
        [Fact]
        public async Task TwoSums_Fact1()
        {
            Solution solution = new Solution();
            int[] input = new[] {3,2,4};
            int target = 6;
            int[] expectedOutput = new[] {1,2};
            
            int[] output = solution.TwoSum(input, target);

            output.Should().BeEquivalentTo(expectedOutput);
        }
        
        
        [Fact]
        public async Task TwoSums_Fact2()
        {
            Solution solution = new Solution();
            int[] input = new[] {2,7,11,15};
            int target = 9;
            int[] expectedOutput = new[] {0, 1};
            
            int[] output = solution.TwoSum(input, target);

            output.Should().BeEquivalentTo(expectedOutput);
        }
        
    }
}