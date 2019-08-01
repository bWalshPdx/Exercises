using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLefRotation
{
    public class Main
    {
        public int[] Generate(int limit)
        {
            return Enumerable.Range(1, limit).ToArray();
        }

        public int[] ShiftLeft(int limit, int shiftPos)
        {
            var currentList = Generate(limit);

            for (int i = 1; i < shiftPos; i++)
            {
                for (int j = limit - i; j > 0; j--)
                {
                    int newIndex;
                    if (j == 0)
                    {
                        newIndex = limit - 1;
                    }
                    else
                    {
                        newIndex = j - 1;
                    }

                    int temp = currentList[newIndex];
                    currentList[newIndex] = currentList[j];
                    currentList[j] = temp;
                }
            }

            return currentList;
        }
    }
}
