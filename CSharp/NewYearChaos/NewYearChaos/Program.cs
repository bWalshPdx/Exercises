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

class Solution
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
            Console.WriteLine("This was hit");

            return new string[]
            {
                "3",
                "Too chaotic"
            };
        }
    }
}