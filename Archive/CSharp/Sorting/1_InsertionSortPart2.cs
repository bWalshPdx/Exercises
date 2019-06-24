using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Sorting
{
    /*
     * Problem Statement

    In Insertion Sort Part 1, you sorted one element into an array. Using the same approach repeatedly, can you sort an entire unsorted array?

    Guideline: You already can place an element into a sorted array. How can you use that code to build up a sorted array, 
     * one element at a time? Note that in the first step, when you consider an element with just the first element - that 
     * is already "sorted" since there's nothing to its left that is smaller.

    In this challenge, don't print every time you move an element. Instead, print the array every time an element is "inserted" 
     * into the array in (what is currently) its correct place. Since the array composed of just the first element is already 
     * "sorted", begin printing from the second element and on.
     * 
    Sample Input
    6
    1 4 3 5 6 2
    Sample Output

    1 4 3 5 6 2 
    1 3 4 5 6 2 
    1 3 4 5 6 2 
    1 3 4 5 6 2 
    1 2 3 4 5 6 

    Sample Input
    9
    9 8 6 7 3 5 4 1 2
    
    Sample Output
    
    8 9 6 7 3 5 4 1 2
    6 8 9 7 3 5 4 1 2
    6 7 8 9 3 5 4 1 2
    3 6 7 8 9 5 4 1 2
    3 5 6 7 8 9 4 1 2
    3 4 5 6 7 8 9 1 2
    1 3 4 5 6 7 8 9 2
    1 2 3 4 5 6 7 8 9 
    
    Explination 
    Insertion Sort checks 4 first and doesn't need to move it, so it just prints out the array. Next, 3 is inserted next to 1, 
    and the array is printed out. This continues one element at a time until the entire array is sorted.

    Task 
    The method insertionSort takes in one parameter: ar, an unsorted array. Use an Insertion Sort Algorithm to sort the entire array.
     */

    

    public class InsertionSortPart2
    {
        public List<int> Sort(string input, bool debug = false)
        {
            var convertedArray = input.Split(' ').Select(e => Convert.ToInt32(e)).ToList();

            return Sort(convertedArray, debug);
        }

        public List<int> Sort(List<int> input, bool debug = false)
        {
            List<int> output = input;
            
            for (int insertFrom = 0; insertFrom < output.Count; insertFrom++) //Work through each element
            {
                int? insertIndex = null;

                for (int insertInto = insertFrom; insertInto >= 0; insertInto--) //Look to the left for a element that is larger than itself
                {
                    if (input[insertInto] > input[insertFrom])
                        insertIndex = insertInto;
                }

                if (insertIndex != null)
                {
                    insertElement(input, insertFrom, insertIndex.Value);
                    PrintArray(output, debug);
                }
                
            }
            

            return output;
        }

        public void insertElement(List<int> input, int insertFrom, int insertInto)
        {
            bool shiftRight = (insertFrom < insertInto);

            int elementToInsert = input[insertFrom];

            int currentIndex = insertFrom;

            while (true)
            {
                if (currentIndex == insertInto)
                    break;

                if (shiftRight)
                {
                    input[currentIndex] = input[currentIndex + 1];
                    currentIndex++;
                }
                else
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }
            }

            input[insertInto] = elementToInsert;
        }

        public StringBuilder IterationLog = new StringBuilder();

        public void PrintArray(IEnumerable<int> array, bool debug)
        {
            var output = array.Aggregate("", (first, second) => first + " " + second);
            output = output.Substring(1);

            if (!debug)
            {
                Console.WriteLine(output);
            }
            else
            {
                IterationLog.AppendLine(output);
            }
        }
    }
}
