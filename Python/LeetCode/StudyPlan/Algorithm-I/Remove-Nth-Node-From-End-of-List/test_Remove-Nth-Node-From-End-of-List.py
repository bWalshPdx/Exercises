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
        # Get the count of the nodes
        total_nodes: int = self.getCount(head)
        # Start the counter at the total nodes and decrease
        current_node_index: int = total_nodes
        # When you get to the number right before:
        # - Get current.next.next
        #  - Make it current.next

        while True:
            if current_node_index == -1:
                break
            if current_node_index == n:

                if head.next != None and head.next.next != None:
                    head.next = head.next.next

                if head.next == None:
                    head = None

            current_node_index = current_node_index - 1

        return head


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

    def ListNodesAreEqual(self, expectedNode, inputNode) -> bool:

        current_expectedNode = expectedNode
        current_inputNode = inputNode

        while True:
            if current_expectedNode.val != current_inputNode.val:
                return False

            if current_expectedNode.next == None and current_inputNode.next == None:
                return True

            current_expectedNode = current_expectedNode.next
            current_inputNode = current_inputNode.next

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




    #@unittest.skip()
    def test_removeNthFromEnd_Fact1(self):
        #<NA> 2021.12.21.11.37.01AM: This is in a endless loop
        solution = Solution()
        inputNode = ListNode()
        inputNode.val = 1

        output = solution.removeNthFromEnd(inputNode, 1)

        self.assertEqual(None, output)

    def test_removeNthFromEnd_Fact2(self):
        solution = Solution()
        inputNode1 = ListNode()
        inputNode1.val = 1
        
        inputNode2 = ListNode()
        inputNode2.val = 2

        inputNode1.next = inputNode2

        expectedNode = ListNode()
        expectedNode.val = 1

        output = solution.removeNthFromEnd(inputNode1, 1)

        is_valid: bool = self.ListNodesAreEqual(expectedNode, output)

        self.assertTrue(is_valid)

        #self.assertEqual(expectedNode, output)

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