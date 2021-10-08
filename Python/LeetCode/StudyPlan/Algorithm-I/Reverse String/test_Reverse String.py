import unittest
from typing import List

if __name__ == '__main__':
    pass

# I did this dumb dumb style. start with 0 and len - 1 and meet:
class Solution:
    def reverseString(self, s: List[str]) -> None:

        current_index: int = 0
        length = len(s)
        while True:
            if length == current_index:
                break

            current_value: str = s.pop(0)
            s.append(current_value)
            current_index = current_index + 1


class TestSolution(unittest.TestCase):

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
