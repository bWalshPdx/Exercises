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
                char head = currentInput.FirstOrDefault();
                string tail = String.Concat(currentInput.Skip(1));

                if (HasMatchingParen(head, tail))
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

        public bool HasMatchingParen(char head, string tail)
        {
            char nextHead = tail.FirstOrDefault();

            //Removing the head and the matching paren:
            //string nextTail = tail.Substring(1,tail.Length - 2);
            string nextTail = String.Concat(tail.Skip(1).Take(tail.Length - 2));

            char matchingParen = tail.Last();

            if (nextHead == '(' || nextHead == '[' || nextHead == '{')
            {
                bool innerParenBalanced = HasMatchingParen(nextHead, nextTail);

                if (!innerParenBalanced)
                {
                    return false;
                }
            }

            

            switch (head)
            {
                case '(':
                    return matchingParen == ')';
                case '[':
                    return matchingParen == ']';
                case '{':
                    return matchingParen == '}';
                default:
                    return false;
            }
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
