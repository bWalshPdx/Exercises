
using System.Threading.Tasks;
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
        public async Task Search_Bootstrap()
        {
            Solution solution = new Solution();

            solution.Search(new int[0], 0);

        }
    }

    
}