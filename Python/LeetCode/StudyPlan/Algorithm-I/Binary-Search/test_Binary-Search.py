import math
import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def search(self, nums: List[int], target: int) -> int:
        halfIndex: int = math.floor(len(nums) / 2 -1)

        if nums[halfIndex] == target:
            return halfIndex


class TestSolution(unittest.TestCase):

    # def test_FromLeetCode(self):
    #     solution = Solution()
    #     self.assertEqual(solution.search([-1, 0, 3, 5, 9, 12], 9), 4)
    #     self.assertEqual(solution.search([-1, 0, 3, 5, 9, 12], 2), -1)

    def test_findAtFirstTry(self):
        solution = Solution()
        self.assertEqual(solution.search([3], 3), 0)