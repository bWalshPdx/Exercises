import string
import unittest
from typing import List

if __name__ == '__main__':
    pass


class Solution(object):
    def numUniqueEmails(self, emails) -> int:
        emailDict: dict = {}
        for email in emails:
            cleanEmail = self.getCleanEmail(email)
            if cleanEmail not in emailDict:
                emailDict[cleanEmail] = 0

        return len(emailDict)

    def getCleanEmail(self, input: string) -> string:
        localName: string = input.split("@")[0]
        domainName: string = input.split("@")[1]
        localName = localName.replace(".", "")
        localName = localName.split("+")[0]
        return f"{localName}@{domainName}"


class TestUniqueEmails(unittest.TestCase):
    def test_Fact1(self):
        solution = Solution()
        emails = ["test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"]
        output: int = solution.numUniqueEmails(emails)
        self.assertEqual(2, output)


    def test_Fact2(self):
        solution = Solution()
        emails = ["a@leetcode.com", "b@leetcode.com", "c@leetcode.com"]
        output: int = solution.numUniqueEmails(emails)
        self.assertEqual(3, output)

    # def test_GetCleanLocalName_RemovesDomain(self):
    #     solution = Solution()
    #     self.assertEqual("brianBubbz", solution.getCleanEmail("brianBubbz@leetcode.com"))
    #     self.assertEqual("myTestUser", solution.getCleanEmail("myTestUser@leetcode.com"))

    def test_GetCleanLocalName_RemovesDots(self):
        solution = Solution()
        self.assertEqual("annielebawitz@leetcode.com", solution.getCleanEmail("annie.lebawitz.@leetcode.com"))

    def test_GetCleanLocalName_StripsToRightOfPlus(self):
        solution = Solution()
        self.assertEqual("annielebawitz@leetcode.com", solution.getCleanEmail("annie.lebawitz+ThisIsATest@leetcode.com"))
        self.assertEqual("annielebawitz@leetcode.com", solution.getCleanEmail("annie.lebawitz+ThisIsA+Test2@leetcode.com"))
