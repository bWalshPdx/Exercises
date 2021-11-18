# Middle_of_the_Linked_List
## Reference
https://leetcode.com/problems/middle-of-the-linked-list/

## Description


876. Middle of the Linked List
Easy

3550

94

Add to List

Share
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

Example 1:

Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:


Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 

Constraints:

The number of nodes in the list is in the range [1, 100].
1 <= Node.val <= 100


--------------------------------

Recieving a error:

Given Input

[65,66,26,77,96,86,11,21,13,80]

AttributeError: 'NoneType' object has no attribute 'val'
    if middle_val == next_head.val:
Line 17 in middleNode (Solution.py)
    ret = Solution().middleNode(param_1)
Line 59 in _driver (Solution.py)
    _driver()
Line 70 in <module> (Solution.py)