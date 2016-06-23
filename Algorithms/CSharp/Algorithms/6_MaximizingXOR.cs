using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MaximizingXOR
{
    //TODO: <NA> FIGURE OUT WHY THE LOOPS ARE DONE BROKE
    //PROBLEM: find the maximal values of A xor B given, L ≤ A ≤ B ≤ R
    public class Solution
    {
        public int getMaxXorCount(int left, int right)
        {
            int MaxXorCount = 0;

            for (int i = 1; i < left; i++)
            {
                for (int j = 1; j < right; j++)
                {
                    int xorCandidate = getXorCount(left, right);

                    if (xorCandidate > MaxXorCount)
                        MaxXorCount = xorCandidate;
                }
            }

            return MaxXorCount;
        }

        public int getXorCount(int left, int right)
        {
            return left ^ right;
        }
    }

    [TestFixture]
    class Solution_Tests
    {
        
        [TestCase(1, 10, 15)]
        [TestCase(10, 15, 7)]
        public void getMaxXorCount_IntegrationTest(int left, int right, int expectedOutput)
        {
            Solution s = new Solution();
            var output = s.getMaxXorCount(left, right);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase(10, 10, 0)]
        [TestCase(10, 11, 1)]
        [TestCase(10, 12, 6)]
        [TestCase(10, 13, 7)]
        public void getXorCount_IntegrationTest(int left, int right, int expectedOutput)
        {
            Solution s = new Solution();
            var output = s.getXorCount(left, right);

            Assert.AreEqual(expectedOutput, output);
        }

    }
}
