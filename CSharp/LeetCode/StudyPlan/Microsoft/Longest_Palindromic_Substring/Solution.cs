
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public string LongestPalindrome(string s)
    {
        return s;
    }

    public bool IsPalindrome(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse( charArray );
        string reversed = new string( charArray );
        
        return reversed == input;
    }
}

public class Solution_Test
{
    [Fact]
    public void LongestPalindrome_ShouldReturnSingleChar()
    {
        Solution s = new Solution();
        string input = "b";
        string output = "b";
    
        s.LongestPalindrome(input).Should().Be(output);
    }
    
    [Fact]
    public void IsPalindrome_ShouldReturnTrue()
    {
        Solution s = new Solution();
        string input = "b";
        bool expectedOutput = true;

        s.IsPalindrome(input).Should().Be(expectedOutput);
    }
    
    [Fact]
    public void IsPalindrome_ShouldReturnFalse()
    {
        Solution s = new Solution();
        string input = "ba";
        bool expectedOutput = false;

        s.IsPalindrome(input).Should().Be(expectedOutput);
    }
}

