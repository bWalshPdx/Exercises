﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLefRotation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string problemDescription = firstLine[0];
            string inputArray = Console.ReadLine();

            string output = GetShiftedArray(problemDescription, inputArray);

            Console.Write(output);
        }


        public static int[] ShiftLeft(int[] sequence, int shiftPos)
        {
            int[] shiftedArray = sequence.Select(e => e).ToArray();

            for (int i = 0; i < sequence.Length; i++)
            {
                int newIndex = GetShiftedIndex(sequence.Length, shiftPos, i);

                shiftedArray[newIndex] = sequence[i];
            }

            return shiftedArray;
        }

        public static int GetShiftedIndex(int arrayLength, int shiftNumber, int originalIndex)
        {
            shiftNumber = shiftNumber % arrayLength;

            int updatedIndex = originalIndex - shiftNumber;

            if (updatedIndex < 0)
            {
                updatedIndex = arrayLength + updatedIndex;
            }

            return updatedIndex;
        }

        public static string GetShiftedArray(string problemDescription, string inputArray)
        {
            int[] splitProblem = problemDescription.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            
            int shiftNum = splitProblem[1];

            int[] splitInput = inputArray.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

            int[] shiftedArray = ShiftLeft(splitInput, shiftNum);

            string output = String.Join(" ", shiftedArray);

            return output;
        }
    }
}