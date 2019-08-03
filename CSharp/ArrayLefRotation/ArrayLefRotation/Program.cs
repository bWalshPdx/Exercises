using System;
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
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        }


        public int[] Generate(int limit)
        {
            return Enumerable.Range(1, limit).ToArray();
        }

        public int[] ShiftLeft(int limit, int shiftPos)
        {
            var currentList = Generate(limit);
            int[] shiftedArray = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                int newIndex = GetShiftedIndex(limit, shiftPos, i);

                shiftedArray[newIndex] = currentList[i];
            }

            return shiftedArray;
        }

        public int GetShiftedIndex(int arrayLength, int shiftNumber, int originalIndex)
        {
            int updatedIndex = originalIndex;
            for (int i = 0; i < shiftNumber; i++)
            {
                int nextIndex = updatedIndex - 1;

                if (nextIndex < 0)
                    nextIndex = arrayLength - 1;

                updatedIndex = nextIndex;
            }

            return updatedIndex;
        }
    }
}
