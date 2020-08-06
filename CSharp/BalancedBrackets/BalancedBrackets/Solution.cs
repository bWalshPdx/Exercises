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
        public List<string> Solve(List<string> input)
        {
            return input;
        }

        public bool HasMatchingParen(char head, string tail)
        {
            char nextHead = tail.FirstOrDefault();

            switch (head)
            {
                case '(':
                    return nextHead == ')';
                default:
                    throw new ArgumentException("Unknown head detected");
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
