
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public string LongestPalindrome(string s)
    {
        for (int index = 0; index < s.Length - 1; index++)
        {
            while (true)
            {
                
            }
            
        }
        
        
        return s;
    }

    public bool IsPalindrome(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse( charArray );
        string reversed = new string( charArray );
        
        return reversed == input;
    }

    public string GetStubstring(List<string> input)
    {
        return "333";
    }

    public string GetStubString(int start, int end, string input)
    {
        return "333";
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
    
    [Fact]
    public void GetStubString_ShouldReturn333()
    {
        Solution s = new Solution();
        string input = "xxx333x";
        
        string output = s.GetStubString(3, 5, input);

        output.Should().Be("333");
    }
    
    
    [Fact()]
    public void GetLongestString_ShouldReturn4444()
    {
        Solution s = new Solution();
        string input = "xxx4444x";
        
        s.GetStubString(3, 5, input).Should().Be("4444");
    }
}

