import unittest

if __name__ == '__main__':
    pass


class Solution(object):
    def numUniqueEmails(self, emails) -> int:
        pass


class TestUniqueEmails(unittest.TestCase):

    def test_Work(self):
        solution = Solution()
        emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"]
        output: int = solution.numUniqueEmails(emails)
        self.assertEqual(3, output)
