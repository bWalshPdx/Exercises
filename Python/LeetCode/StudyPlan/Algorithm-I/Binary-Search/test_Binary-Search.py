import math
import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def search(self, nums: List[int], target: int) -> int:
        nextMove:int = len(nums) // 2
        currentIndex:int = nextMove
        while True:

            if nums[currentIndex] == target:
                return currentIndex
            elif nextMove == 0:
                return -1

            nextMove: int = nextMove // 2
            if nextMove == 0:
                nextMove = 1

            if nums[currentIndex] > target:
                currentIndex = currentIndex - nextMove
            else:
                currentIndex = currentIndex + nextMove

            if (nextMove == 1):
                nextMove = 0


class TestSolution(unittest.TestCase):
    #@unittest.skip("reason for skipping")
    def test_FromLeetCode(self):
        solution = Solution()
        self.assertEqual(solution.search([-1, 0, 3, 5, 9, 12], 9), 4)
        self.assertEqual(solution.search([-1, 0, 3, 5, 9, 12], 2), -1)

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
