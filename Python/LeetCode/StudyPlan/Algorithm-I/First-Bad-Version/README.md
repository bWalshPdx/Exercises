# First-Bad-Version
## Reference
https://leetcode.com/problems/first-bad-version/

## Description

You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

 

Example 1:

Input: n = 5, bad = 4
Output: 4
Explanation:
call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true
Then 4 is the first bad version.

Example 2:

Input: n = 1, bad = 1
Output: 1

 

Constraints:

    1 <= bad <= n <= 231 - 1

## Iteration 1

I am calling isBadVersion(N) -> returns a bool


1, 2 , 3, 4, 5

4 is the bad version

if 3 is not bad go right.
if 3 is bad go left.



2021.09.07.05.56.18PM <NA>: Trying to figure out how to update a variable outside of a class (just in a file) and change
it within my test. Its treating the variable as if it were local.

2021.09.08.06.06.18PM <NA>: Trying to debug a error I am getting with my first test