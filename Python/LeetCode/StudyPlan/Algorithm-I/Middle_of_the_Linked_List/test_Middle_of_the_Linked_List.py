import math
import unittest
from typing import Optional

if __name__ == '__main__':
    pass


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:

        total_length: int = self.getCount(head)
        if total_length == 0:
            return None

        middle_val: int = math.ceil(total_length / 2)
        current_val: int = 1
        next_head = head

        while True:
            if middle_val == current_val:
                return next_head
            else:
                current_val = current_val + 1
            next_head = head.next


    def getCount(self, head: ListNode) -> int:
        count: int = 0
        nextHead: ListNode = head

        if head == None:
            return 0

        while True:
            if nextHead != None:
                count = count + 1
            else:
                break

            nextHead = nextHead.next

        return count









class TestSolution(unittest.TestCase):

    # @unittest.skip()
    def test_ReturnsFirstElementOfOneElement(self):
        solution = Solution()
        node = ListNode()
        node.val = 0
        outputNode = ListNode()
        outputNode.val = 0
        self.assertEqual(outputNode.val, solution.middleNode(node).val)

    def test_ReturnsMiddleOfThreeNodes(self):
        solution = Solution()
        node1 = ListNode()
        node1.val = 0

        node2 = ListNode()
        node2.val = 1

        node3 = ListNode()
        node3.val = 2

        node2.next = node3
        node1.next = node2

        outputNode = ListNode()
        outputNode.val = 1
        self.assertEqual(outputNode.val, solution.middleNode(node1).val)

    def test_GetCount_Returns3(self):
        solution = Solution()
        node1 = ListNode()
        node1.val = 0

        node2 = ListNode()
        node2.val = 1

        node3 = ListNode()
        node3.val = 2

        node2.next = node3
        node1.next = node2

        self.assertEqual(3, solution.getCount(node1))

    def test_GetCount_Returns0(self):
        solution = Solution()
        node1 = None

        self.assertEqual(0, solution.getCount(node1))