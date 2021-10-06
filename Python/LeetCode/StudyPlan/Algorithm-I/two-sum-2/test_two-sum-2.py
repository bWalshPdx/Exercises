import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        sub_array = []

        current_value = 0
        while True:
            if numbers[current_value] > target:
                break

            if numbers[current_value] < target:
                sub_array.append(numbers[current_value])

            current_value = current_value + 1

        outer_index = 0
        inner_index = 1
        while True:

            while True:
                if (sub_array[outer_index] + sub_array[inner_index]) == target:
                    return [sub_array[outer_index], sub_array[inner_index]]
                inner_index = inner_index + 1

            outer_index = outer_index + 1


        return []


class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_Fact1(self):
        solution = Solution()
        self.assertEqual([1], solution.twoSum([1], 1))

    @unittest.skip()
    def test_Fact2(self):
        solution = Solution()
        self.assertEqual([1, 2], solution.twoSum([1, 2], 3))
