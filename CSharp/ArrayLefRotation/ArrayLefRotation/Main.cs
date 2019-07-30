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
            return Enumerable.Range(1, 5).ToArray();
        }

        public int[] ShiftLeft(int limit, int shiftPos)
        {
            var originalList = Generate(limit);

            int[] shiftedList = originalList;

            for (int i = 0; i < shiftPos; i++)
            {
                for (int j = limit - 1; j == 0; j--)
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

                    int temp = originalList[j];



                }
            }
        }
    }
}
