using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Valid_Palindrome
{
    public class Solution {
        public bool IsPalindrome(string input)
        {
            string cleanedInput = cleanString(input);
            
            List<char> reversed = new List<char>();

            for (int i = cleanedInput.Length - 1; i > -1; i--)
            {
                reversed.Add(cleanedInput[i]);
            }

            string output = new string(reversed.ToArray());
            return cleanedInput == output;
        }

        public string cleanString(string input)
        {
            var cleanedUpCharArray = input.Where(i => "abcdefghijklmnopqrstuvwxyz".Contains(i)).ToArray();

            return new string(cleanedUpCharArray);
        }
    }
    
    public class Solution_Tests
    {
        [Fact]
        public async Task Fact1()
        {
            Solution sol = new Solution();
            string input = "race a car";
            bool expectedOutput = false;
            bool isPalindrome =  sol.IsPalindrome(input);

            isPalindrome.Should().Be(expectedOutput);
        }
        
        [Fact]
        public async Task Fact2()
        {
            Solution sol = new Solution();
            string input = " ";
            bool expectedOutput = true;
            bool isPalindrome =  sol.IsPalindrome(input);

            isPalindrome.Should().Be(expectedOutput);
        }
        
        [Fact]
        public async Task Fact3()
        {
            Solution sol = new Solution();
            string input = "A man, a plan, a canal: Panama";
            bool expectedOutput = true;
            bool isPalindrome =  sol.IsPalindrome(input);

            isPalindrome.Should().Be(expectedOutput);
        }
        
        [Fact]
        public async Task Fact4()
        {
            Solution sol = new Solution();
            string input = "race a car";
            bool expectedOutput = false;
            bool isPalindrome =  sol.IsPalindrome(input);

            isPalindrome.Should().Be(expectedOutput);
        }
    }
}