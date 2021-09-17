import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def searchInsert(self, nums: List[int], target: int) -> int:
        if len(nums) == 1:
            if nums[0] == target:
                return 0

        if len(nums) == 0:
            return 0

        return self.searchInsertSection(nums, target, 0, len(nums) - 1)

    def searchInsertSection(self, nums: List[int], target: int, left: int, right: int):
        mid = (left + right) // 2

        current_Value = nums[mid]

        if current_Value == target:
            return mid

        if target > current_Value: # Go Right:
            return self.searchInsertSection(nums, target, mid + 1, right)
        else:
            return self.searchInsertSection(nums, target, left, mid - 1)





class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_Example1_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([1], 1))

    def test_Example2_ReturnsIndexToInsert(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([], 1))

    def test_Example3_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([1, 2], 1))

    def test_Example4_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([1, 2], 1))

    def test_Example5_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(1, solution.searchInsert([1, 2], 2))

    def test_Example5_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([1, 2, 3], 1))
