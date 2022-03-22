using System.Text;
using FluentAssertions;
using Xunit;

namespace ATOI;

public class Solution {
    public int MyAtoi(string input)
    {
        bool getIntegerChars = false;
        StringBuilder sb = new StringBuilder();
        

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsWhiteSpace(input[i]))
            {
                getIntegerChars = false;

                if (getIntegerChars)
                {
                    break;
                }
            }
            else if (input[i] == '-')
            {
                if (getIntegerChars)
                {
                    getIntegerChars = false;
                    break;
                }
                else
                {
                    getIntegerChars = true;
                }
            }
            else if (Char.IsDigit(input[i]))
            {
                getIntegerChars = true;
            }
            
            if(getIntegerChars)
                sb.Append(input[i]);
        }
        
        return Int32.Parse(sb.ToString());
    }

    
}


public class Solution_Test
{
    [Fact]
    public void Fact1()
    {
        Solution solution = new Solution();
        string input = "42";
        int expectedOutput = 42;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void Fact2()
    {
        Solution solution = new Solution();
        string input = "   -42";
        int expectedOutput = -42;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void Fact3()
    {
        Solution solution = new Solution();
        string input = "4193 with words";
        int expectedOutput = 4193;
        
        //<NA> Need to remove the leading white space, then check for a -, then check for integers and cut off the value

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public void Fact4()
    {
        Solution solution = new Solution();
        string input = "words and 987";
        int expectedOutput = 0;

        //<NA> Need to remove the leading white space, then check for a -, then check for integers and cut off the value

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

}