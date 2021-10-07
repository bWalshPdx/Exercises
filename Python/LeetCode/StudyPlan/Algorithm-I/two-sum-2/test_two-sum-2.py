import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:

        outer_index = 0
        inner_index = 1
        while True:
            if outer_index == len(numbers):
                break

            while True:
                if inner_index == len(numbers):
                    break

                if (numbers[outer_index] + numbers[inner_index]) == target:
                    return [outer_index + 1, inner_index + 1]
                inner_index = inner_index + 1

            outer_index = outer_index + 1
            inner_index = outer_index + 1


class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_Fact1(self):
        solution = Solution()
        self.assertEqual([1, 2], solution.twoSum([1, 2], 3))

    def test_Fact1(self):
        solution = Solution()
        self.assertEqual([1, 2], solution.twoSum([1, 1], 2))

    def test_LC_Example1(self):
        solution = Solution()
        self.assertEqual([1, 2], solution.twoSum([2, 7, 11, 15], 9))

    def test_LC_Example2(self):
        solution = Solution()
        self.assertEqual([1, 3], solution.twoSum([2, 3, 4], 6))

    def test_LC_Example3(self):
        solution = Solution()
        self.assertEqual([1, 2], solution.twoSum([-1, 0], -1))

    def test_LC_Example4(self):
        solution = Solution()
        self.assertEqual([1, 2], solution.twoSum([-3, 3, 4, 90], 0))

    def test_LC_Example5(self):
        solution = Solution()
        self.assertEqual([2, 3], solution.twoSum([5, 25, 75], 100))

    def test_LC_Example6(self):
        solution = Solution()
        self.assertEqual([4,5], solution.twoSum([1, 2, 3, 4, 4, 9, 56, 90], 8))