import math
import unittest
from typing import Optional

if __name__ == '__main__':
    pass


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


    def createNode(self, number_of_nodes: int) -> ListNode:
        if number_of_nodes == 0:
            return None

        current_val = number_of_nodes
        current_node = ListNode()
        current_node.val = number_of_nodes

        while True:
            if current_val == 1:
                return current_node

            new_node = ListNode()

            current_val = current_val - 1

            new_node.val = current_val
            new_node.next = current_node

            current_node = new_node

        return output_node












class TestSolution(unittest.TestCase):

    # @unittest.skip()
    def test_ReturnsFirstElementOfOneElement(self):
        solution = Solution()
        node = ListNode()
        node.val = 1
        outputNode = ListNode()
        outputNode.val = 1
        self.assertEqual(outputNode.val, solution.middleNode(node).val)

    def test_ReturnsMiddleOfOddNodes(self):
        solution = Solution()
        testNodes = solution.createNode(5)

        outputNode = ListNode()
        outputNode.val = 3
        self.assertEqual(outputNode.val, solution.middleNode(testNodes).val)

    def test_ReturnsMiddleOfEvenNodes(self):
        solution = Solution()
        testNodes = solution.createNode(6)

        outputNode = ListNode()
        outputNode.val = 4
        self.assertEqual(outputNode.val, solution.middleNode(testNodes).val)



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

    def test_CreateNodes_Returns1(self):
        solution = Solution()
        testNode = solution.createNode(1)

        self.assertEqual(1, solution.getCount(testNode))

    def test_CreateNodes_Returns3(self):
        solution = Solution()
        testNode = solution.createNode(3)

        self.assertEqual(3, solution.getCount(testNode))

    def test_CreateNodes_ValuesAreCorrect(self):
        solution = Solution()
        testNode = solution.createNode(3)

        self.assertEqual(1, testNode.val)
        self.assertEqual(2, testNode.next.val)
        self.assertEqual(3, testNode.next.next.val)
