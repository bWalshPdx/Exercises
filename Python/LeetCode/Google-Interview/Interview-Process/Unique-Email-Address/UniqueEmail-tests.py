import unittest
from typing import List


if __name__ == '__main__':
    pass


class Solution(object):
    def numUniqueEmails(self, emails) -> int:


        return 2

class TestUniqueEmails(unittest.TestCase):

    def test_Fact1(self):
        solution = Solution()
        emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"]
        output: int = solution.numUniqueEmails(emails)
        self.assertEqual(2, output)

    def test_Fact2(self):
        solution = Solution()
        emails = ["a@leetcode.com","b@leetcode.com","c@leetcode.com"]
        output: int = solution.numUniqueEmails(emails)
        self.assertEqual(3, output)

    def test_emailLooks(self):
        solution = Solution()
        emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"]
        output: int = solution.numUniqueEmails(emails)
        self.assertEqual(2, output)