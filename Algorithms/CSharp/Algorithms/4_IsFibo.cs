using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Algorithms
{
    /* Find all fibonacci numbers up to 10^10
	    -Enumerate through the sequence going from 0 to 10^10
	    -As you find a fibonacci number, stash it in a hashset
        
       Check if the input is in that list and return IsFibo or IsNotFibo
     */



    //COMPLETE
    public static class IsFibo
    {
        
        public static string IsItAFibo(int input, HashSet<int> fiboSet)
        {
            if (fiboSet.Contains(input))
                return "IsFibo";

            return "IsNotFibo";
        }

        public static IEnumerable<int> getFibos(int upperLimit)
        {
            int first = 0;
            int second = 1;

            int current = -1;

            yield return first;
            yield return second;

            while (current < upperLimit)
            {
                current = first + second;

                first = second;
                second = current;

                yield return current;
            }
        }

        public static HashSet<int> getFiboSet(int upperLimit)
        {
            return new HashSet<int>(getFibos(upperLimit));
        }
    }

    [TestFixture]
    public class IsFibo_Tests
    {
        [TestCase(13, "0,1,1,2,3,5,8,13")]
        public void getFibos(int upperLimit,string expectedOutput)
        {
            var testSequence = expectedOutput.Split(',').Select(e => Convert.ToInt32(e)).ToArray();

            var output = IsFibo.getFibos(13).ToArray();

            Assert.That(testSequence.SequenceEqual(output));
        }

        [TestCase(3, "IsFibo")]
        [TestCase(6, "IsNotFibo")]
        [TestCase(8, "IsFibo")]
        public void IsItAFibo(int input, string expectedOutput)
        {
            var output = IsFibo.IsItAFibo(input, IsFibo.getFiboSet(20));

            Assert.That(output == expectedOutput);
        }


    }
}
