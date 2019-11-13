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
                bool bribeFound = true;
                int totalBribeCount = 0;

                int currentSortedIndex = line.Length - 1;

                while (bribeFound)
                {
                    
                    bribeFound = false;

                    for (int i = currentSortedIndex; i >= 0; i--)
                    {
                        int properValue = i + 1;

                        if (line[i] > properValue)
                        {
                            bribeFound = true;
                            int currentBribeCount = line[i] - (i + 1);

                            if (currentBribeCount >= 3)
                            {
                                return "Too chaotic";
                            }

                            totalBribeCount += currentBribeCount;

                            //Perform Swaps for the number of bribes found:
                            for (int j = i; j < i + currentBribeCount; j++)
                            {
                                int firstValue = line[j];
                                int secondValue = line[j + 1];
                                line[j + 1] = firstValue;
                                line[j] = secondValue;
                            }

                            currentSortedIndex = i;

                            break;
                        }
                    }
                }

                return totalBribeCount.ToString();

            }
        }
    }
}

