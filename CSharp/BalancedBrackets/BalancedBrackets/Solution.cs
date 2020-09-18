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

            Solution solution = new Solution();

            List<string> output = solution.Solve(input);

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

                if (IsBalanced(currentInput))
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

        public bool IsBalanced(string input)
        {
            if (input.Length % 2 != 0)
            {
                return false;
            }


            List<Tuple<char,char>> bracketPairs = new List<Tuple<char, char>>()
            {
                new Tuple<char, char>('(',')'),
                new Tuple<char, char>('[',']'),
                new Tuple<char, char>('{','}')
            };

            Stack<char> stackOfBrackets = new Stack<char>();

            Tuple<char, char> currentPair;

            foreach (char currentChar in input)
            {
                currentPair = bracketPairs.FirstOrDefault(bp => bp.Item1 == currentChar || bp.Item2 == currentChar);

                if (currentPair == null)
                {
                    throw new Exception("Weird character detected. wtf");
                }

                if (currentPair.Item1 == currentChar)
                {
                    stackOfBrackets.Push(currentChar);

                    continue;
                }

                if (stackOfBrackets.Any() && currentPair.Item1 == stackOfBrackets.Peek())
                {
                    stackOfBrackets.Pop();

                    continue;
                }
            }

            return !stackOfBrackets.Any();
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
