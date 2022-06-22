
using System.Xml.Linq;
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
                //<NA> do the below:
                //Get the start/end indexes for substring
                //Get substring
                //Check if substring is a palandrome
                //Save the palindrome for output
                //add to length
                
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

    public string GetSubstring(int start, int end, string input)
    {
        List<char> tempArray = new List<char>();
        
        for (int i = start; i <= end; i++)
        {
            tempArray.Add(input[i]); 
        }

        return new String(tempArray.ToArray());
    }

    public Tuple<int, int> GetSubStringValues(int currentIndex, int length, string input)
    {
        int start = currentIndex;
        int end = (currentIndex + length) - 1;
        Tuple<int, int> output = new Tuple<int, int>(start, end);

        return output;

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
        
        string output = s.GetSubstring(3, 5, input);

        output.Should().Be("333");
    }
    
    
    [Fact()]
    public void GetLongestString_ShouldReturn4444()
    {
        Solution s = new Solution();
        string input = "xxx4444x";
        
        s.GetSubstring(3, 6, input).Should().Be("4444");
    }
    
    [Fact()]
    public void GetLongestString_ShouldReturn1()
    {
        Solution s = new Solution();
        string input = "1xxxxxx";
        
        s.GetSubstring(0, 0, input).Should().Be("1");
    }
    
    [Fact()]
    public void GetSubStringValues_Fact1()
    {
        Solution s = new Solution();
        string input = "1xxxxxx";
        int currentIndex = 0;
        int length = 1;
        Tuple<int, int> expectedOutput = new Tuple<int, int>(0, 0);
            
        Tuple<int,int> output =  s.GetSubStringValues(currentIndex, length, input);
        
        output.Should().Be(expectedOutput);
    }
    
    [Fact()]
    public void GetSubStringValues_Fact2()
    {
        Solution s = new Solution();
        string input = "xxx4444x";
        int currentIndex = 3;
        int length = 4;
        Tuple<int, int> expectedOutput = new Tuple<int, int>(3, 6);
            
        Tuple<int,int> output =  s.GetSubStringValues(currentIndex, length, input);
        
        output.Should().Be(expectedOutput);
    }
    
}

