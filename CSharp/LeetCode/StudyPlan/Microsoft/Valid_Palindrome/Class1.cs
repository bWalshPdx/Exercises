using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Valid_Palindrome
{
    public class Solution {
        public bool IsPalindrome(string s)
        {
            return s == new String(s.Reverse().ToArray());
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
    }
}