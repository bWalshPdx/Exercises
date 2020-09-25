using System;
using System.Collections.Generic;

namespace MaximumElement
{
    public static class Go
    {
        public static void Main(string[] args)
        {
            var input = HackerRankIo.ReceiveInput();

            List<string> output =  Solution.Solve(input);

            HackerRankIo.ReturnOutput(output);
        }
    }


    public static class Solution
    {
        public static List<string> Solve(List<string> input)
        {
            return input;
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
