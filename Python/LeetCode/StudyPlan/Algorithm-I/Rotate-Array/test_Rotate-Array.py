import unittest
from typing import List


if __name__ == '__main__':
    pass


class Solution:

    def get_new_index(self, array_length: int, current_index: int, shift: int) -> int:

        if shift == 0:
            return current_index

        new_index = current_index + shift

        if new_index <= (array_length - 1):
            return new_index

        new_index = (current_index + shift) % array_length

        return new_index

    def rotate(self, nums: List[int], k: int) -> None:
        output = [None] * len(nums)

        if len(nums) <= 1:
            return nums

        for index, item in enumerate(nums):
            new_index = self.get_new_index(len(nums), index, k)
            output[new_index] = item

        nums[:] = output


class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_rotate_EmptyListReturnsEmptyList(self):
        solution = Solution()
        input = []
        solution.rotate(input, 0)
        self.assertEqual([], input)

    def test_rotate_SingleListReturnsTheSame(self):
        solution = Solution()
        input = [1]
        solution.rotate(input, 0)
        self.assertEqual([1], input)

    def test_newIndex_Example1(self):
        solution = Solution()
        array_length = 0
        current_index = 0
        shift = 0
        self.assertEqual(0, solution.get_new_index(array_length, current_index, shift))

    def test_newIndex_Example2(self):
        solution = Solution()
        array_length = 2
        current_index = 0
        shift = 1
        self.assertEqual(1, solution.get_new_index(array_length, current_index, shift))

    def test_newIndex_Example3(self):
        solution = Solution()
        array_length = 2
        current_index = 1
        shift = 1
        self.assertEqual(0, solution.get_new_index(array_length, current_index, shift))

    def test_newIndex_Example4(self):
        solution = Solution()
        array_length = 4
        current_index = 2
        shift = 4
        self.assertEqual(2, solution.get_new_index(array_length, current_index, shift))

    def test_newIndex_Example5(self):
        solution = Solution()
        array_length = 5
        current_index = 0
        shift = 7
        self.assertEqual(2, solution.get_new_index(array_length, current_index, shift))

    def test_newIndex_LC_Example1(self):
        solution = Solution()
        input = [1, 2, 3, 4, 5, 6, 7]
        solution.rotate(input, 3)
        self.assertEqual([5, 6, 7, 1, 2, 3, 4], input)