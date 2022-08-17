
using System.Xml.Linq;
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public string LongestPalindrome(string s)
    {
        //<NA> Need to make it faster:
        string currentBestPalindrome = "";
        for (int index = 0; index <= s.Length - 1; index++)
        {
            int currentLength = currentBestPalindrome.Length;
            while (true)
            {//Get the start/end indexes for substring
                int start = index;
                int end = start + currentLength;

                if (s.Length - 1 < end)
                    break;

                //Get substring
                string substring = GetSubstring(start, end, s);
                //Check if substring is a palindrome
                //Save the palindrome for output
                if (IsPalindrome(substring))
                {
                    if(currentBestPalindrome.Length < substring.Length)
                        currentBestPalindrome = substring;
                }
                //add to length
                currentLength++;
            }

        }

        return currentBestPalindrome;
    }

    public bool IsPalindrome(string input)
    {
        double splitInt = input.Length / 2;
        double index = Math.Floor(splitInt); 
        
        double left = -1;
        double right = -1;
        
        
        //Set pointers if a even length:
        if (input.Length % 2 == 0)
        {
            left = index - 1;
            right = index;
        }
        else
        {
            left = index - 1;
            right = index + 1;
        }
        
        
        
        //check the bounds for pointers:
        if (left < 0)
            left = 0;

        if (right > (input.Length - 1))
            right = input.Length - 1;
        
        while (true)
        {
            if (left < 0)
                break;

            if (right > (input.Length - 1))
                break;

            char leftChar = input[(int)left];
            char rightChar = input[(int)right];
            
            if (leftChar != rightChar)
                return false;

            left--;
            right++;
        }

        return true;
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
    #region LongestPalindrome
    
    [Fact]
    public void LongestPalindrome_ShouldReturnSingleChar()
    {
        Solution s = new Solution();
        string input = "b";
        string output = "b";
    
        s.LongestPalindrome(input).Should().Be(output);
    }
    
    //[Fact(Skip = "Fixing palindrome first")]
    [Fact]
    public void LongestPalindrome_ShouldReturnBab()
    {
        Solution s = new Solution();
        string input = "babad";
        string output = "bab";
    
        s.LongestPalindrome(input).Should().Be(output);
    }
    
    #endregion

    #region IsPalindrome

    [Fact]
    public void IsPalindrome_ShouldReturnTrue_Fact1()
    {
        Solution s = new Solution();
        string input = "b";
        bool expectedOutput = true;

        s.IsPalindrome(input).Should().Be(expectedOutput);
    }
    
    [Fact]
    public void IsPalindrome_ShouldReturnFalse_Fact1()
    {
        Solution s = new Solution();
        string input = "ba";
        bool expectedOutput = false;

        s.IsPalindrome(input).Should().Be(expectedOutput);
    }
    
    [Fact]
    public void IsPalindrome_ShouldReturnFalse_Fact2()
    {
        Solution s = new Solution();
        string input = "baba";
        bool expectedOutput = false;
    
        s.IsPalindrome(input).Should().Be(expectedOutput);
    }
    
    #endregion

    #region Misc
    
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

    #endregion
    
    
    
}

