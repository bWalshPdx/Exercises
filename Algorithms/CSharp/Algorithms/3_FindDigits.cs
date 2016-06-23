using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Algorithms
{
    //COMPLETE
    public class Solution
    {
        public int getDigitModCount(int input)
        {
            int modCount = 0;

            foreach (var i in input.ToString())
            {
                var currentInt = Convert.ToInt32(i.ToString());

                if (currentInt != 0 && input % currentInt == 0)
                    modCount++;
            }

            return modCount;
        }
    }

    [TestFixture]
    public class FindDigits_Tests
    {
        
        public void ParseStuff()
        {
            
        }


        [TestCase(24, 2)]
        [TestCase(122, 3)]
        [TestCase(1012, 3)]
        public void FindDigits_IntegrationTest(int input, int correctDigits)
        {
            Solution fd = new Solution();

            int output = fd.getDigitModCount(input);

            Assert.AreEqual(correctDigits, output);
        }

        
    }
}
