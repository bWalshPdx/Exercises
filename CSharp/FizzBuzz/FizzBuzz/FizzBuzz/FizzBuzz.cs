using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;





namespace FizzBuzz
{
    public static class Solution
    {
        static void Main(String[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            Console.Write(fizzBuzz.GetCollection(100));
        }
    }

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

        public string GetCollection(int limit)
        {
            var range = Enumerable.Range(1, limit).ToList();
            StringBuilder sb = new StringBuilder();

            range.ForEach(e => sb.AppendLine(Convert(e)));

            return sb.ToString();
        }
    }
}
