
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
