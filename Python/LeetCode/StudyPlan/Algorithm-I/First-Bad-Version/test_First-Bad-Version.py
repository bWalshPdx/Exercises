import unittest
from typing import List

if __name__ == '__main__':
    pass

badVersionForTest = -1


def isBadVersion(n: int) -> bool:
    return badVersionForTest <= n

class Solution:
    def firstBadVersion(self, highest_version_number: int) -> int:
        new_input: List[int] = list(range(1, highest_version_number + 1))
        if highest_version_number == 1:
            return highest_version_number

        return self.getNextBadVersion(new_input, 0, len(new_input) - 1)

    def getNextBadVersion(self, current_input: List[int], left: int, right: int) -> int:
        if left > right:
            return -1

        mid = (left + right) // 2
        left_result = -1
        right_result = -1
        currentValue = mid + 1
        is_bad = isBadVersion(currentValue)

        if is_bad:
            left_result = self.getNextBadVersion(current_input, left, mid - 1) #Go Left to find earlier bad version
        else:
            right_result = self.getNextBadVersion(current_input, mid + 1, right) #Go Right to find later bad version

        if is_bad:
            if left_result == -1 and right_result == -1:
                return current_input[mid]

            return left_result

        return right_result

        # if is_bad and left_result == -1:
        #     return current_input[mid]
        # else:
        #     return right_result



class TestSolution(unittest.TestCase):

    # @unittest.skip()
    def test_ListOf0(self):
        solution = Solution()

        global badVersionForTest
        badVersionForTest = 1
        self.assertEqual(badVersionForTest, solution.firstBadVersion(1))

    def test_ListOf2(self):
        solution = Solution()

        global badVersionForTest
        badVersionForTest = 1
        self.assertEqual(badVersionForTest, solution.firstBadVersion(2))

        badVersionForTest = 2
        self.assertEqual(badVersionForTest, solution.firstBadVersion(2))

    def test_FromLeetCode_Round1(self):
        solution = Solution()

        global badVersionForTest
        badVersionForTest = 1
        self.assertEqual(badVersionForTest, solution.firstBadVersion(4))

    @unittest.skip("Takes a long time to run")
    def test_FromLeetCode_Round2(self):
        solution = Solution()

        global badVersionForTest
        badVersionForTest = 1702766719
        self.assertEqual(badVersionForTest, solution.firstBadVersion(2126753390))