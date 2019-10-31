using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace MyNamespace
{
    public class Solution
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            New_Year_Chaos mySolution = new New_Year_Chaos();

            var output = mySolution.Solution(q);

            foreach (string i in output)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }
        public class New_Year_Chaos
        {
            public string[] Solution(int[] input)
            {
                return new string[]
                {
                    "3",
                    "Too chaotic"
                };
            }

            public int GetBribeCount(string[] line, string id)
            {
                for (int i = Int32.Parse(id) - 1; i >= 0; i--)
                {
                    if (line[i] == id)
                    {
                        return line.Length - (i + 1);
                    }
                }

                throw new Exception("Can't find a id in the line");
            }
        }




        public class HackerRankHarness
        {
            private readonly UseType _type;
            private readonly Func<IEnumerable<string>, IEnumerable<string>> _solution;

            public enum UseType { Console, File };

            public HackerRankHarness(Func<IEnumerable<string>, IEnumerable<string>> solution)
            {
                _type = UseType.Console;
                _solution = solution;
            }

            public HackerRankHarness(string inputFilePath, string outputFilePath, Func<IEnumerable<string>, IEnumerable<string>> solution)
            {
                _type = UseType.File;
                _solution = solution;
            }

            public void Input()
            {
                List<string> inputCollection = new List<string>();

                if (_type == UseType.Console)
                {
                    //TODO: Figure out a way to break after a certain amount of time when waiting for console readline
                }

            }

            public void Output()
            {

            }
        }
    }
}

