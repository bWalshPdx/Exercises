import unittest
from typing import Optional

if __name__ == '__main__':
    pass


# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:

        return head


class TestSolution(unittest.TestCase):

    # @unittest.skip()
    def test_Fact1(self):
        solution = Solution()
        node = ListNode()
        node.val = 0
        outputNode = ListNode()
        outputNode.val = 0
        self.assertEqual(outputNode.val, solution.middleNode(node).val)
