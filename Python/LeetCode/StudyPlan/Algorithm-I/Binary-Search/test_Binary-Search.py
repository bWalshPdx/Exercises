import math
import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def search(self, nums: List[int], target: int) -> int:
        next_move: int = len(nums) // 2
        current_index: int = next_move
        while True:

            if nums[current_index] == target:
                return current_index
            elif next_move == 0:
                return -1

            next_move: int = next_move // 2
            if next_move == 0:
                next_move = 1

            if nums[current_index] > target:
                current_index = current_index - next_move
            else:
                current_index = current_index + next_move

            if next_move == 1:
                next_move = 0


class TestSolution(unittest.TestCase):
    #@unittest.skip("reason for skipping")
    def test_FromLeetCode(self):
        solution = Solution()
        self.assertEqual(4, solution.search([-1, 0, 3, 5, 9, 12], 9))
        self.assertEqual(-1, solution.search([-1, 0, 3, 5, 9, 12], 2))

    # @unittest.skip("reason for skipping")
    def test_FromLeetCode_Round2(self):
        solution = Solution()
        self.assertEqual(5, solution.search([-1, 0, 3, 5, 9, 12], 12))


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
