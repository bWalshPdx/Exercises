using System.Text;
using FluentAssertions;
using Microsoft.VisualBasic.CompilerServices;
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
            else if (Char.IsLetter(input[i]))
            {
                getIntegerChars = false;
                break;
            }

            if (getIntegerChars)
                sb.Append(input[i]);
        }

        Int32.TryParse(sb.ToString(), out int formattedInteger);

        return formattedInteger;
    }

    public int MyToInt(char[] input)
    {
        int multiple = 1;
        int output = 0;
        
        foreach (char currentChar in input.Reverse())
        {
            Int32.TryParse(currentChar.ToString(), out int formattedInteger);
            output = (formattedInteger * multiple) + output;

            multiple = multiple * 10;
        }

        //Int32.TryParse(input[0].ToString(), out int formattedInteger);
        return output;
    }
}


public class Solution_Test
{
    [Fact]
    public void MyAtoi_Fact1()
    {
        Solution solution = new Solution();
        string input = "42";
        int expectedOutput = 42;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void MyAtoi_Fact2()
    {
        Solution solution = new Solution();
        string input = "   -42";
        int expectedOutput = -42;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void MyAtoi_Fact3()
    {
        Solution solution = new Solution();
        string input = "4193 with words";
        int expectedOutput = 4193;
        
        //<NA> Need to remove the leading white space, then check for a -, then check for integers and cut off the value

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public void MyAtoi_Fact4()
    {
        Solution solution = new Solution();
        string input = "words and 987";
        int expectedOutput = 0;

        //<NA> Need to remove the leading white space, then check for a -, then check for integers and cut off the value

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact()]
    public void MyAtoi_Fact5()
    {
        Solution solution = new Solution();
        string input = "-91283472332";
        int expectedOutput = -2147483648;

        //<NA> Need to remove the leading white space, then check for a -, then check for integers and cut off the value

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public async Task MyToInt_Fact1()
    {
        Solution solution = new Solution();
        char[] input = new []{'1'};
        int expectedOutput = 1;

        int output = solution.MyToInt(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public async Task MyToInt_Fact2()
    {
        Solution solution = new Solution();
        char[] input = new []{'1', '1'};
        int expectedOutput = 11;

        int output = solution.MyToInt(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public async Task MyToInt_Fact3()
    {
        Solution solution = new Solution();
        char[] input = new []{'1', '0', '0', '1'};
        int expectedOutput = 1001;

        int output = solution.MyToInt(input);
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public async Task MyToInt_Fact4()
    {
        Solution solution = new Solution();
        string input = "91283472332";
        int expectedOutput = 2147483647;

        //<NA> Need to remove the leading white space, then check for a -, then check for integers and cut off the value

        int output = solution.MyToInt(input.ToCharArray());
        output.Should().Be(expectedOutput);
    }
}