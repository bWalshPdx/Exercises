import unittest
from typing import List

if __name__ == '__main__':
    pass

# I did this dumb dumb style. start with 0 and len - 1 and meet:
class Solution:
    def reverseString(self, s: List[str]) -> None:
        start: int = 0
        end: int = len(s) - 1

        while True:
            if start > end:
                break

            startVal = s[start]
            endVal = s[end]
            s[start] = endVal
            s[end] = startVal

            start = start + 1
            end = end - 1

        return s


class TestSolution(unittest.TestCase):

    def test_Fact1(self):
        solution = Solution()
        i = ["i"]
        solution.reverseString(i)
        self.assertEqual(["i"], i)

    def test_Fact2(self):
        solution = Solution()
        i = ["i", "h"]
        solution.reverseString(i)
        self.assertEqual(["h", "i"], i)

    #@unittest.skip()
    def test_LC_Example1(self):
        solution = Solution()
        i = ["h", "e", "l", "l", "o"]
        solution.reverseString(i)
        self.assertEqual(["o", "l", "l", "e", "h"], i)

    def test_LC_Example2(self):
        solution = Solution()
        i = ["H", "a", "n", "n", "a", "h"]
        solution.reverseString(i)
        self.assertEqual(["h", "a", "n", "n", "a", "H"], i)
