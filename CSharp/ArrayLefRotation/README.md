# Hacker Rank: Array Left Rotation:

## Problem:

A left rotation operation on an array shifts each of the array's elements  unit to the left. For example, if  left rotations are performed on array , then the array would become .

Given an array  of  integers and a number, , perform  left rotations on the array. Return the updated array to be printed as a single line of space-separated integers.

Function Description

Complete the function rotLeft in the editor below. It should return the resulting array of integers.

rotLeft has the following parameter(s):

An array of integers .
An integer , the number of rotations.
Input Format

The first line contains two space-separated integers  and , the size of  and the number of left rotations you must perform. 
The second line contains  space-separated integers .

Constraints

Output Format

Print a single line of  space-separated integers denoting the final state of the array after performing  left rotations.

Sample Input

5 4
1 2 3 4 5
Sample Output

5 1 2 3 4

## Reference:

https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays


## Thoughts for the next iteration:

Have your 'guiding test' done first

Figure out the smallest state change and test for that first.

Get better at the actual keyboard shortcut workflow for writing tests in visual studio 2019


## Things that will make it harder next time:

Instead of going from right to left, solve it going from left to right

Can I get a 'hole in one' (The test passes in one run)

Can you solve it without debugging?

Return the the shifted array lazily.

Can I solve this being just as performant with a high number of shifts as a single shift.