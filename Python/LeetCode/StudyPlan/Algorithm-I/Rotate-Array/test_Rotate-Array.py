import unittest
from typing import List


if __name__ == '__main__':
    pass


class Solution:

    def get_new_index(self, array_length:int, current_index: int, shift: int) -> int:

        if shift == 0:
            return current_index

        #newIndex: int = current_index + shift
        adjusted_shift: int = (current_index + shift) // array_length

        return current_index + adjusted_shift


    def rotate(self, nums: List[int], k: int) -> None:
        return nums
        """
        Do not return anything, modify nums in-place instead.
        """

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


    # def test_TwoElementsRotateOne(self):
    #     solution = Solution()
    #     input = [1, 2]
    #     solution.rotate(input, 1)
    #     self.assertEqual([2, 1], input)
