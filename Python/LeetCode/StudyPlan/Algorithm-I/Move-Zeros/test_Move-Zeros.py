import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def moveZeroes(self, nums: List[int]) -> None:

        if len(nums) <= 1:
            return nums


class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_ZeroElementsReturnEmpty(self):
        solution = Solution()
        self.assertEqual([], solution.moveZeroes([]))

    def test_OneElementsReturnsOneArray(self):
        solution = Solution()
        self.assertEqual([1], solution.moveZeroes([1]))
