using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BalancedBrackets
{
    public class Go
    {
        static void Main(string[] args)
        {
            List<string> input = HackerRankIo.ReceiveInput();

            List<string> fakeOutput = new List<string>()
            {
                "YES",
                "NO"
            };

            Solution solution = new Solution();

            List<string> output = solution.Solve(fakeOutput);

            HackerRankIo.ReturnOutput(output);
        }
    }

    public class Solution
    {
        public List<string> Solve(List<string> inputCollection)
        {
            List<string> output = new List<string>();


            foreach (var currentInput in inputCollection)
            {
                //char head = currentInput.FirstOrDefault();
                //string tail = String.Concat(currentInput.Skip(1));

                if (HasMatchingParen(currentInput))
                {
                    output.Add("YES");
                }
                else
                {
                    output.Add("NO");
                }
            }

            return output;
        }

        public bool HasMatchingParen(string input)
        {
            if (input.Length == 0)
            {
                return true;
            }

            if (input.Length < 2)
            {
                return false;
            }

            if (input.Length % 2 != 0)
            {
                return false;
            }

            char head = input.FirstOrDefault();

            char matchingParen;

            switch (head)
            {
                case '(':
                    matchingParen = ')';
                    break;
                case '[':
                    matchingParen = ']';
                    break;
                case '{':
                    matchingParen = '}';
                    break;
                default:
                    return false;
            }


            int matchingParenIndex = input.Length - 1;
            while (matchingParenIndex != 0)
            {
                if (matchingParenIndex == 0)
                {
                    //No closing paren found:
                    return false;
                }

                if (input[matchingParenIndex] == matchingParen)
                {
                    break;
                }

                matchingParenIndex--;
            }

            //If the opening paren is right next to the closing paren:
            if (matchingParenIndex == 1)
            {
                return true;
            }

            //Prep the input for recursion:

            //Remove the opening paren and closing paren:
            string firstSplit = String.Concat(input.Skip(1).Take(matchingParenIndex - 1));

            string secondSplit = String.Concat(input.Skip(matchingParenIndex + 1));



            //Removing the head and the matching paren:
            //string nextTail = tail.Substring(1,tail.Length - 2);
            //string nextTail = String.Concat(tail.Skip(1).Take(tail.Length - 2));

            //char matchingParen = tail.Last();

            bool firstSplitBalanced = true;
            bool secondSplitBalanced = true;

            if (firstSplit.Any())
            {
                firstSplitBalanced = HasMatchingParen(firstSplit);
            }

            if (secondSplit.Any())
            {
                secondSplitBalanced = HasMatchingParen(secondSplit);
            }

            return firstSplitBalanced && secondSplitBalanced;
        }
    }

    public static class HackerRankIo
    {
        public static List<string> ReceiveInput()
        {
            int elementsInputted = Int32.Parse(System.Console.ReadLine());

            List<string> input = new List<string>();

            for (int i = 0; i < elementsInputted; i++)
            {
                input.Add(System.Console.ReadLine());
            }

            return input;
        }

        public static void ReturnOutput(List<string> output)
        {
            foreach (var currentOutput in output)
            {
                System.Console.WriteLine(currentOutput);
            }
        }
    }
}
