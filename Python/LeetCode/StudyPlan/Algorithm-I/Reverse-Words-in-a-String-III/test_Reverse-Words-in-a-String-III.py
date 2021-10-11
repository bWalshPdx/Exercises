import unittest

if __name__ == '__main__':
    pass

# <NA> 2021.10.11.10.02.54AM: Working on reversing a single word just like the previous problem, then move up to multiple words:
class Solution:
    def reverseWords(self, s: str) -> str:
        start: int = 0
        end: int = len(s) - 1

        while True:
            start = start + 1
            end = end -1





        return "i"


class TestSolution(unittest.TestCase):

    #@unittest.skip()
    def test_Fact1(self):
        solution = Solution()
        self.assertEqual("i", solution.reverseWords("i"))


    def test_Fact1(self):
        solution = Solution()
        self.assertEqual("ih", solution.reverseWords("hi"))