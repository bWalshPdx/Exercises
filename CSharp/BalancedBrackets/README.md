
# HackerRank: Balanced Brackets:
***

A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().

A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

By this logic, we say a sequence of brackets is balanced if the following conditions are met:

- It contains no unmatched brackets.
- The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.

Given n strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, return YES. Otherwise, return NO.

Function Description

Complete the function isBalanced in the editor below. It must return a string: YES if the sequence is balanced or NO if it is not.

isBalanced has the following parameter(s):

s: a string of brackets
Input Format

The first line contains a single integer , the number of strings.
Each of the next  lines contains a single string , a sequence of brackets.


## References:
***

https://www.hackerrank.com/challenges/balanced-brackets/problem

## Research:
***

Simplest way to write this is via recursion. It will also make a better lead to the recursive descent parser.

For my own constraint, I can again write it with a actual stack datastructure that I create


Mapping Recursive strategy to stack datatype:

Recurse => Push

Return one frame => Pop

looking at return value => Peek

size => passing along a counter (uneeded in this exercise)

isEmpty => not Needed in this exercise


*Psuedo code:*

- Get the first character of the incoming string

- IF: Opening paren, recurse with new substring and opening paren.
- IF: Closed paren, check the passed along open paren and if the it matches the type return true, else false.


* 2020.08.07.09.24.10AM: New way to parse after working through Guidance test 2 *

{(([])[])[]} <= Original

{           }

 (      )
  (  )
   []
      []
          []


Start with the first character and move towards the middle from the end to get its matching paren

2020.08.11.08.30.42AM: New Psuedo code:

1. Get first paren:
- Verify its a open parentheses

2. Get closing paren:
- Start at the end of the string, hunting for the matching closing parentheses working inwards.

3. Split the string to prepare for the recursion
- Split the string by the end parentheses

- Remove the first parentheses from the first split string

4. recurse





#### Example Guiding Tests:
Test1:
Input:
2
{{([])}}
{{)[](}}

Output:
YES
NO

Test2:

Input:
3
{(([])[])[]}
{(([])[])[]]}
{(([])[])[]}[]

Output:
YES
NO
YES

Test0:

Input:
3
{[()]}
{[(])}
{{[[(())]]}}

Output:
YES
NO
YES


## Journal:
***

<NA> 2020.08.04.09.13.35AM: Write out psuedo code for exercise


<NA> 2020.08.05.09.38.00AM: write out first tests to solution from psuedo code

<NA> 2020.08.06.09.41.45AM: verifying prep of tail to recurse


Note: I feel like there is always a 'pivot' where I discover something I didn't think about from the initial psuedo code.


<NA> 2020.08.11.09.24.15AM: Tests are failing with new split string refactor

Fix how strings are split

	first split: skip first, take up the matching closing paren (not including)

	second split: take everything after the match

2020.08.19.09.16.42AM <NA> Figure out why things are passing in the test, but not hackerrank

//2020.08.31.08.33.14AM: Its the last 'yes' that is wrong:

//2020.09.15.08.47.20AM: Trying to figure out this particular pattern: {}{()}{{}} 
	- It is a valid set of parens.


	https://www.geeksforgeeks.org/check-for-balanced-parentheses-in-python/

	"One approach to check balanced parentheses is to use stack. Each time, when an open parentheses is encountered push it in the stack, and when closed parenthesis is encountered, match it with the top of stack and pop it. If stack is empty at the end, return Balanced otherwise, Unbalanced.""
	<NA>: Figure out the last test that is breaking

<DONE>@:2020.09.18.08.40.18AM: All tests are now passing

2020.09.18.09.17.38AM: Need to see what in that huge test is failing, the fix it. Maybe add additional simple tests:
	- Verify it doesn't start with a open bracket. 
	- Verify it has equal open and closing bracket of each type.

	THEN: get into using a stack.

2020.09.22.08.56.24AM: This 


## Retrospective:
***

What are the best aspects of the design of the code we’ve ended up with?:

	I had two major ways of solving the problem, the first was using a recursvice decent parser. I have one move, and I use the crap out of it. 

	However, that became hard to implement so I backed out of it 80% of the way through.

	I actually used the datastructure that was meant for the exercise, like a bone head I tried to solve it like I would have parsing a math problem.

	Once the stack was implemented, it was SO much easier. I feel like there is a good value in trying to figure it out yourself, but also I need to better understand
	the theory of what I am trying to do first.

In what ways did we do Test Driven Development particularly well?

	The tests really came in handy when I made small changes at the end. I felt like I was able to do small refactors without it being a big risk.

Did we learn anything new?

	I used a stack, which is not something I normally use, but it worked so well right after implementing it, I should understand better how the stack is doing the heavy 
	lifting in this exercise.

Did anything unexpected happen?

	I felt my recursive descent parser would have worked if I put more effort into it, however I think it was too complicated for what I was trying to do. The stack solved
	the problem without adding much complexity.

What do we still need to practice more?

	I need to practice how to leverage a particular datastructure to do the heavy lifting, do more research on how to solve the problem first rather than using your solutions that you already know to shoe-horn it into the solution

What should we do differently in the next dojo?

	I think the practice was good. It took me longer than it should have. I need to suffer with my own attempt to solve it a bit less. Learn from others first, then come up with different ways to solve the problem.

What will you do differently tomorrow in your production code?

	Im not sure I will ever find a spot to use stacks in my current code, but I would love to try one day.

