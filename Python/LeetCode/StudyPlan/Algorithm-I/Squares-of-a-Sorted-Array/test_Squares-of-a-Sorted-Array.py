import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution:
    def sortedSquares(self, nums: List[int]) -> List[int]:
        output = [None] * len(nums)
        left_pointer = 0
        right_pointer = len(nums) - 1
        output_pointer = right_pointer

        if len(nums) == 0:
            return nums

        while True:
            if abs(nums[left_pointer]) < abs(nums[right_pointer]):
                output[output_pointer] = nums[right_pointer] * nums[right_pointer]
                right_pointer = right_pointer - 1
            else:
                output[output_pointer] = nums[left_pointer] * nums[left_pointer]
                left_pointer = left_pointer + 1

            output_pointer = output_pointer - 1

            if output_pointer == -1:
                break

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

    def test_LCExample1(self):
        solution = Solution()
        self.assertEqual([0, 1, 9, 16, 100], solution.sortedSquares([-4, -1, 0, 3, 10]))

    def test_LCExample2(self):
        solution = Solution()
        self.assertEqual([4, 9, 9, 49, 121], solution.sortedSquares([-7, -3, 2, 3, 11]))