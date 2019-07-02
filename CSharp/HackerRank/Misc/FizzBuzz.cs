using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank.Misc
{
    public static class FizzBuzz
    {
        public static string Converter(int input)
        {
            if (input % 5 == 0 && input % 3 == 0)
            {
                return "FizzBuzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }

            if (input % 5 == 0)
            {
                return "Buzz";
            }

            return input.ToString();
        }

        public static string GetOutput(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
