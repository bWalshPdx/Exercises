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

            Console.WriteLine(mySolution.GetBribeCountForLine(q));
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
            
            public string GetBribeCountForLine(int[] line)
            {
                int bribeCount = 0;

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    int currentBribeCount = 0;

                    if (line[i] > i)
                    {
                        currentBribeCount = line[i] - (i + 1);

                        if (currentBribeCount >= 3)
                        {
                            return "Too chaotic";
                        }

                        bribeCount += currentBribeCount;

                        //Capture value that made the bribes:
                        

                        //Capture range of values that need to move:
                        int startIndex = i + 1;
                        int endIndex = i + currentBribeCount;


                        //Move the range up by current vote count:


                    }





                }

                return bribeCount.ToString();
            }
        }
    }
}

