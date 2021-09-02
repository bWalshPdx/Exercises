import unittest
from typing import List

from solution import Solution

if __name__ == '__main__':
    pass


class TestSolution(unittest.TestCase):
    def test_Fact1(self):
        solution = Solution()
        output: List[int] = solution.twoSum([2, 7, 11, 15], 9)
        self.assertListEqual(output, [0, 1])

    def test_Fact2(self):
        solution = Solution()
        output: List[int] = solution.twoSum([3, 3], 6)
        self.assertListEqual(output, [0, 1])

    def test_Fact3(self):
        solution = Solution()
        output: List[int] = solution.twoSum([3, 2, 4], 6)
        self.assertListEqual(output, [1, 2])

    def test_Fact4(self):
        solution = Solution()
        output: List[int] = solution.twoSum([2, 5, 5, 11], 10)
        self.assertListEqual(output, [1, 2])
