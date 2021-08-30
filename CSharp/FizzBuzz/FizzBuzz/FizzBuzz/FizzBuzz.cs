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
        public string GetOutput(List<int> input)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (var i in input)
            {
                string current;
                if (i % 3 == 0)
                {
                    current = "Fizz ";
                }
                else
                {
                    current = i + " ";
                }
                sb.Append(current);
            }
            
            string output = sb.ToString();

            if (output.Last() == ' ')
            {
                output = output.Substring(0, output.Length - 1);
            }
            
            return output;
        }
    }
}
