import unittest
from typing import Optional

if __name__ == '__main__':
    pass

#Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        return head





class TestSolution(unittest.TestCase):

    def ListNodesAreEqual(self, expectedNode, inputNode) -> bool:

        current_expectedNode = expectedNode
        current_inputNode = inputNode

        while(True):
            if(current_expectedNode.val != current_inputNode.val):
                return False

            if (current_expectedNode.next == None and current_inputNode.next == None):
                return True

            current_expectedNode = current_expectedNode.next
            current_inputNode = current_inputNode.next


    #@unittest.skip()
    def test_Fact1(self):
        solution = Solution()
        inputNode = ListNode()
        inputNode.val = 0

        expectedNode = ListNode()
        expectedNode.val = 0

        self.assertEqual(expectedNode.val, solution.removeNthFromEnd(inputNode, 0).val)

    def test_ListNodesAreEqual_GivenSingleNode_BothAreEqual(self):
        inputNode = ListNode()
        inputNode.val = 0

        expectedNode = ListNode()
        expectedNode.val = 0

        nodesAreEqual:bool = self.ListNodesAreEqual(expectedNode, inputNode)

        self.assertEqual(True, nodesAreEqual)

    def test_ListNodesAreEqual_GivenTwoNodes_BothAreEqual(self):
        inputNode0 = ListNode()
        inputNode0.val = 0

        inputNode1 = ListNode()
        inputNode1.val = 1

        inputNode0.next = inputNode1

        expectedNode0 = ListNode()
        expectedNode0.val = 0

        expectedNode1 = ListNode()
        expectedNode1.val = 1

        expectedNode0.next = expectedNode1

        nodesAreEqual:bool = self.ListNodesAreEqual(expectedNode0, inputNode0)

        self.assertEqual(True, nodesAreEqual)

    def test_ListNodesAreEqual_GivenTwoNodes_NotEqual(self):
        inputNode0 = ListNode()
        inputNode0.val = 0

        inputNode1 = ListNode()
        inputNode1.val = 2

        inputNode0.next = inputNode1

        expectedNode0 = ListNode()
        expectedNode0.val = 0

        expectedNode1 = ListNode()
        expectedNode1.val = 1

        expectedNode0.next = expectedNode1

        nodesAreEqual:bool = self.ListNodesAreEqual(expectedNode0, inputNode0)

        self.assertEqual(False, nodesAreEqual)