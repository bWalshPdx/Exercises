import math
import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def search(self, nums: List[int], target: int) -> int:
        return self.search_section(nums, target, 0, len(nums) - 1)

    def search_section(self, nums: List[int], target: int, left: int, right: int):
        if left > right:
            return -1

        current_index: int = (left + right) // 2
        current_val = nums[current_index]
        if target == current_val:
            return current_index
        elif target < current_val: #Go Left:
            return self.search_section(nums, target, left, current_index - 1)
        elif target > current_val:  # Go Right:
            return self.search_section(nums, target, current_index + 1, right)


class TestSolution(unittest.TestCase):
    #@unittest.skip("reason for skipping")
    def test_FromLeetCode(self):
        solution = Solution()
        self.assertEqual(4, solution.search([-1, 0, 3, 5, 9, 12], 9))
        self.assertEqual(-1, solution.search([-1, 0, 3, 5, 9, 12], 2))

    #@unittest.skip("reason for skipping")
    def test_FromLeetCode_Round2(self):
        solution = Solution()
        self.assertEqual(5, solution.search([-1, 0, 3, 5, 9, 12], 12))

    #@unittest.skip("reason for skipping")
    def test_FromLeetCode_Round3(self):
        solution = Solution()
        self.assertEqual(0, solution.search([2, 5], 2))

    #@unittest.skip("reason for skipping")
    def test_findAtFirstTry(self):
        solution = Solution()
        self.assertEqual(0, solution.search([3], 3))
        self.assertEqual(1, solution.search([1, 2, 3], 2))
        self.assertEqual(2, solution.search([1, 2, 3, 4, 5], 3))

    #@unittest.skip("reason for skipping")
    def test_findAtSecondTry(self):
        solution = Solution()
        self.assertEqual(0, solution.search([1, 2, 3], 1))
        self.assertEqual(2, solution.search([1, 2, 3], 3))
