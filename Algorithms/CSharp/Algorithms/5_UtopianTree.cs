using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Algorithms
{
    public class UtopianTree
    {

        public static int getTreeHeight(int cycles)
        {
            int isHeight = 1;
            bool isSpring = true;

            for (int i = 0; i < cycles; i++)
            {
                if (isSpring)
                {
                    isHeight = isHeight * 2;
                }
                else
                {
                    isHeight = isHeight + 1;
                }

                isSpring = !isSpring;

            }

            return isHeight;
        }

    }

    [TestFixture]
    public class UtopianTree_Tests
    {
        [TestCase(3, 6)]
        [TestCase(4, 7)]
        public void getTreeHeight(int cycles, int expectedOutput)
        {
            var output = UtopianTree.getTreeHeight(cycles);

            Assert.AreEqual(expectedOutput, output);
        }
    }

}
