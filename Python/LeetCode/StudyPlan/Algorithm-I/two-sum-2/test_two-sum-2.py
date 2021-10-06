import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        sub_array = []

        current_value = 0
        while True:
            if len(numbers) == current_value:
                break

            if numbers[current_value] > target or numbers[current_value] != 0: #This needs to be fixed to handle zero
                break

            if numbers[current_value] <= target or numbers[current_value] == 0:
                sub_array.append(numbers[current_value])

            current_value = current_value + 1

        outer_index = 0
        inner_index = 1
        while True:

            while True:
                if (sub_array[outer_index] + sub_array[inner_index]) == target:
                    return [outer_index + 1, inner_index + 1]
                inner_index = inner_index + 1

            outer_index = outer_index + 1


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
