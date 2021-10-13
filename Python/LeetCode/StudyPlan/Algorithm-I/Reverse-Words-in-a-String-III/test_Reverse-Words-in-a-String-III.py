import unittest

if __name__ == '__main__':
    pass

# <NA> 2021.10.11.10.02.54AM: Working on reversing a single word just like the previous problem, then move up to multiple words:
class Solution:
    def reverseWords(self, s: str) -> str:
        sArr = list(s)
        start: int = 0
        end: int = len(s) - 1

        while True:

            if end < start:
                break

            startVal = sArr[start]
            endVal = sArr[end]

            sArr[start] = endVal
            sArr[end] = startVal

            start = start + 1
            end = end - 1

        return ''.join(sArr)


class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_Fact1(self):
        solution = Solution()
        self.assertEqual("i", solution.reverseWords("i"))


    def test_Fact2(self):
        solution = Solution()
        self.assertEqual("ih", solution.reverseWords("hi"))

    def test_Fact3(self):
        solution = Solution()
        self.assertEqual("olleh", solution.reverseWords("hello"))