import unittest
from typing import List

if __name__ == '__main__':
    pass

# Reimplementing with suggested solution to speed it up:
class Solution:
    def twoSum(self, numbers: List[int], target: int) -> List[int]:

        low = 0
        high = len(numbers) - 1
        while True:
            if low < high:
                break

            sum = numbers[low] + numbers[high]

            if sum == target:
                return [low + 1, high + 1]
            elif sum < target:
                low = low + 1
            else:
                high = high - 1







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