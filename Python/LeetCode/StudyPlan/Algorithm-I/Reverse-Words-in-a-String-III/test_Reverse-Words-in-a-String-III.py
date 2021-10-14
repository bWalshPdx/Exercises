import unittest

if __name__ == '__main__':
    pass

# <NA> 2021.10.13.10.48.16AM: Working on 'append' or something similar that will join the reversed sentence
class Solution:

    def reverseWords(self, s: str) -> str:
        sentenceArr = s.split(' ')

        i = 0
        while True:
            tempVal = len(sentenceArr) - 1
            if tempVal < i:
                break

            sentenceArr[i] = self.reverseOneWord(sentenceArr[i])

            i = i + 1

        return " ".join(sentenceArr)

    def reverseOneWord(self, s: str) -> str:
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

    def test_TwoWordsAreReversed(self):
        solution = Solution()
        self.assertEqual("ih ih", solution.reverseWords("hi hi"))

    def test_LCExample1(self):
        solution = Solution()
        self.assertEqual("s'teL ekat edoCteeL tsetnoc", solution.reverseWords("Let's take LeetCode contest"))

    def test_LCExample2(self):
        solution = Solution()
        self.assertEqual("doG gniD", solution.reverseWords("God Ding"))