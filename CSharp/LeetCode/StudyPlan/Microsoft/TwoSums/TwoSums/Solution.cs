using System;
using System.Threading.Tasks;
using Xunit;

namespace TwoSums
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target)
        {
            throw new NotImplementedException();
        }
    }


    public class Solution_Tests
    {
        [Fact]
        public async Task TwoSums_Bootstrap()
        {
            Solution solution = new Solution();
            solution.TwoSum(new[] {0}, 0);
        }
    }
}