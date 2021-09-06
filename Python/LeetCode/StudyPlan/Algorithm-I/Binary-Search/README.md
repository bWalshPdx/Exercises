## Reference

https://leetcode.com/problems/binary-search/

## Introduction
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4

Example 2:

Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1

Constraints:

    1 <= nums.length <= 104
    -104 < nums[i], target < 104
    All the integers in nums are unique.
    nums is sorted in ascending order.


# I am stuck for 25 minutes, tapping. Going to the solution:

### Iteration 2:

Understanding the algorithm better, i needed to keep track of the bounds of the search by using left and right pointers
https://www.youtube.com/watch?v=P3YID7liBug&ab_channel=HackerRank
https://www.youtube.com/watch?v=tgVSkMA8joQ&ab_channel=mCoding