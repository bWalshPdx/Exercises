/*
 * https://www.hackerrank.com/challenges/insertionsort1
 * Problem Statement

Sorting 
One common task for computers is to sort data. For example, people might want to see all their files on a computer sorted by size. Since sorting is a simple problem with many different possible solutions, it is often used to introduce the study of algorithms.

Insertion Sort 
These challenges will cover Insertion Sort, a simple and intuitive sorting algorithm. We will first start with an already sorted list.

Insert element into sorted list 
Given a sorted list with an unsorted number V in the rightmost cell, can you write some simple code to insert V into the ar so that it remains sorted?

Print the ar every time a value is shifted in the ar until the ar is fully sorted. The goal of this challenge is to follow the correct order of insertion sort.

Guideline: You can copy the value of V to a variable and consider its cell "empty". Since this leaves an extra cell empty on the right, you can shift everything over until V can be inserted. This will create a duplicate of each value, but when you reach the right spot, you can replace it with V.

Input Format 
There will be two lines of input:

s - the size of the ar
ar - the sorted ar of integers
Output Format 
On each line, output the entire ar every time an item is shifted in it.

Constraints 
1≤s≤1000 
−10000≤V≤10000,V∈ar

Sample Input

5
2 4 6 8 3
Sample Output

2 4 6 8 8 
2 4 6 6 8 
2 4 4 6 8 
2 3 4 6 8 
Explanation

3 is removed from the end of the ar.
In the 1st line 8>3, so 8 is shifted one cell to the right. 
In the 2nd line 6>3, so 6 is shifted one cell to the right. 
In the 3rd line 4>3, so 4 is shifted one cell to the right. 
In the 4th line 2<3, so 3 is placed at position 2.

Task

Complete the method SortElement which takes in one parameter:

ar - an ar with the value V in the right-most cell.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sorting
{
    public class InsertionSortPart1
    {
        
        public List<int> Sort(string ar, bool debug = false)
        {
            var inputArray = ar.Split(' ').Select(i => Int32.Parse(i)).ToList();

            return Sort(inputArray, debug);
        }

        public List<int> Sort(List<int> inputArray, bool debug = false)
        {
            
            var insertElement = inputArray.Last();

            inputArray = inputArray.Take(inputArray.Count - 1).ToList();

            if (inputArray.Last() <= insertElement)
            {
                inputArray.Add(insertElement);
                PrintArray(inputArray, debug);
                //return inputArray;
            }
            else
            {
                inputArray.Add(inputArray.Last());
            }

            //TODO: Figure out a way to use this with both insert sort 1 and 2:

            var newInput = inputArray;
            
            for (int i = inputArray.Count() - 1; i > 0; i--)
            {
                newInput =  SortElement(inputArray, i, insertElement, debug);

                if (i != 0)
                    insertElement = inputArray[i - 1];
                
            }

            return newInput;
        }

        public List<int> SortElement(List<int> array, int currentIndex, int insertValue, bool debug)
        {
            if (currentIndex == -1)
                return array;

            if (currentIndex != 0)
                array[currentIndex] = array[currentIndex - 1];

            if (currentIndex == 0 || array[currentIndex - 1] <= insertValue)
            {
                array[currentIndex] = insertValue;
                PrintArray(array, debug);
                return array;
            }

            PrintArray(array, debug);
            return SortElement(array, currentIndex - 1, insertValue, debug);
        }

        public void PrintArray(IEnumerable<int> array, bool debug)
        {
            if (!debug)
            {
                var output = array.Aggregate("", (first, second) => first + " " + second);
                output = output.Substring(1);
                Console.WriteLine(output);
            }
        }
    }

    

}


