import unittest
from typing import List

if __name__ == '__main__':
    pass

badVersionForTest = -1


def isBadVersion(n: int) -> bool:
    return n == badVersionForTest

class Solution:
    def firstBadVersion(self, n: int) -> int:
        input: List[int] = range(0, n)
        self.getNextBadVersion(input, 0, len(input))

    def getNextBadVersion(self, input: List[int], left: int, right: int) -> int:
        mid = left + right // 2
        left_result = -1
        right_result = -1
        is_bad = isBadVersion(input[mid])

        if is_bad:
            left_result = self.getNextBadVersion(List[int], left, mid - 1) # Go Left to find earlier bad version
        else:
            right_result = self.getNextBadVersion(List[int], mid + 1, right)  # Go Right to find later bad version

        if is_bad and left_result == -1:
            return input[mid]
        else:
            return right_result



class TestSolution(unittest.TestCase):

    # @unittest.skip()
    def test_Fact1(self):
        solution = Solution()

        global badVersionForTest
        badVersionForTest = 1
        self.assertEqual(1, solution.firstBadVersion(1))
        #self.assertEqual(1, solution.firstBadVersion(2))
