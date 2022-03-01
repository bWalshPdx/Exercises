
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
            int left = 0;
            int right = nums.Length - 1;
            
            while (left <= right)
            {
                int pivot = GetPivot(left, right);
                if (nums[pivot] == target)
                    return pivot;

                if (nums[pivot] < target) //Split Right
                {
                    left = pivot + 1;
                }
                if (nums[pivot] > target) //Split Left
                {
                    right = pivot - 1;
                }
            }
            
            return -1;
        }

        public int GetPivot(int left, int right)
        {
            return left + (right - left) / 2;
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
        
        [Fact]
        public async Task LeetCode_Fact1()
        {
            Solution solution = new Solution();
            int[] input = new int[] {-1,0,3,5,9,12};
            int target = 9;
            int expectedIndex = 4;

            int output = solution.Search(input, target);

            output.Should().Be(expectedIndex);
        }
        //[-1,0,3,5,9,12]
        //2
        
        
        [Fact]
        public async Task LeetCode_Fact2()
        {
            Solution solution = new Solution();
            int[] input = new int[] {-1,0,3,5,9,12};
            int target = 2;
            int expectedIndex = -1;

            int output = solution.Search(input, target);

            output.Should().Be(expectedIndex);
        }

        [Fact]
        public async Task GetPivot_SameLeftAndRight_ReturnsLeft()
        {
            Solution solution = new Solution();
            int left = 1;
            int right = 1;
            int pivot = solution.GetPivot(left, right);

            pivot.Should().Be(1);
        }
        
        [Fact]
        public async Task GetPivot_StartOfArray_Fact1()
        {
            Solution solution = new Solution();
            int left = 0;
            int right = 2;
            int pivot = solution.GetPivot(left, right);

            pivot.Should().Be(1);
        }
        
        [Fact]
        public async Task GetPivot_MiddleOfArray_Fact1()
        {
            Solution solution = new Solution();
            int left = 2;
            int right = 4;
            int pivot = solution.GetPivot(left, right);

            pivot.Should().Be(3);
        }
        
        
        
    }

    
}