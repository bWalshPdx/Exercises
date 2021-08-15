import unittest
from itertools import count

from solution import Solution

if __name__ == '__main__':
    pass

class TestSolution(unittest.TestCase):
    def test_two_sum_returnsValue(self):
        solution = Solution()
        self.assertTrue(len(solution.twoSum()) > 0)
