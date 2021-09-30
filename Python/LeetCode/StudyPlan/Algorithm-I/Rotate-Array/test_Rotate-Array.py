import unittest
from typing import List


if __name__ == '__main__':
    pass


class Solution:
    def rotate(self, nums: List[int], k: int) -> None:
        return nums
        """
        Do not return anything, modify nums in-place instead.
        """

class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_EmptyListReturnsEmptyList(self):
        solution = Solution()
        input = []
        solution.rotate(input, 0)
        self.assertEqual([], input)

    def test_TwoElementsRotateOne(self):
        solution = Solution()
        input = [1, 2]
        solution.rotate(input, 1)
        self.assertEqual([2, 1], input)
