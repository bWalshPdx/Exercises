import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        output = []
        if len(nums) == 0:
            return nums

        for i in nums:
            output.append(i * i)

        return output

class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_EmptyReturnsEmpty(self):
        solution = Solution()
        self.assertEqual([], solution.sortedSquares([]))


    def test_SingleElementReturnsSquare1(self):
        solution = Solution()
        self.assertEqual([1], solution.sortedSquares([1]))

    def test_SingleElementReturnsSquare2(self):
        solution = Solution()
        self.assertEqual([100], solution.sortedSquares([10]))

    def test_SingleElementReturnsSquare2(self):
        solution = Solution()
        self.assertEqual([1, 100], solution.sortedSquares([10, 1]))
