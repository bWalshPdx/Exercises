
# Valid_Parentheses
-------------------------
Leetcode description:
https://leetcode.com/explore/interview/card/microsoft/30/array-and-strings/179/

## Prepping for writing the Solution

### Rules of the Problem:

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

Constraints:

    1 <= s.length <= 104
    s consists of parentheses only '()[]{}'.

An input string is valid if:

    1. Open brackets must be closed by the same type of brackets.
    2. Open brackets must be closed in the correct order.


### Proposed tests for each rule:

Input => ((, false
Input => )), false
Input => )(, false
Input => (), true

I need to use a stack

## Reflection:
### What are the best aspects of the design of the code I've ended up with?

I used stacks which was great. I had 3 at first which was a problem. But then I simplified it at the very end which was great.
I found a spot in the middle of working on the problem where I needed to refactor to clean things ups. I think 
in the end I found a cleaner solution.


### In what ways did I do Test Driven Development particularly well?

Other than the obvious leetcode test and solve for that, I think it just made things easier to refactor over and over again.


### Did I learn anything new?

I felt I had a good amount of control, and I wasn't really lost. I did think about the problem a bit in the middle, but nothing 
too major.

### Did anything unexpected happen?
I had a sneaking suspision my original solution had issues with it, but I was willing to plug it into leetcode to give it a try and get more info.

### What do I still need to practice more?

I could go about solving the problem in a different way as shown in the solution. Solving it from the inside out which was interesting.

### What should you do differently in the next exercise?

