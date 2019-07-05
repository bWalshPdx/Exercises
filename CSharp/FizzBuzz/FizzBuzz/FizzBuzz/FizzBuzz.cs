using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Convert(int input)
        {
            string output = "";

            if (input % 3 == 0)
            {
                output += "Fizz";
            }

            if (input % 5 == 0)
            {
                output += "Buzz";
            }

            if (output == "")
            {
                output = input.ToString();
            }

            return output;
        }
    }
}
