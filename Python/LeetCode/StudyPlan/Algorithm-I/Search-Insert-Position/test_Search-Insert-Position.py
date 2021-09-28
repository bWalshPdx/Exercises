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

        # Detect Ends:
        direct_left: int
        direct_right: int

        if (mid - 1) < 0:
            direct_left = target - 1
        else:
            direct_left = nums[mid - 1]

        if (len(nums) - 1) < (mid + 1):
            direct_right = target + 1
        else:
            direct_right = nums[mid + 1]

        if direct_left < target < current_Value:
            return mid - 1

        if current_Value < target < direct_right:
            return mid + 1






        if target > current_Value: # Go Right:
            return self.searchInsertSection(nums, target, mid + 1, right)
        else:
            return self.searchInsertSection(nums, target, left, mid - 1)





class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_Example1_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([1], 1))

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

    def test_Example6_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(4, solution.searchInsert([1, 2, 3, 4, 5, 6], 5))

    def test_Example7_ReturnsCurrentIndex(self):
        solution = Solution()
        self.assertEqual(99, solution.searchInsert(range(1, 101), 100))

    def test_Example8_ReturnsIndexToInsert(self):
        solution = Solution()
        self.assertEqual(0, solution.searchInsert([], 1))

    def test_Example8_ReturnsIndexToInsert(self):
         solution = Solution()
         self.assertEqual(1, solution.searchInsert([0], 1))


