using System.Text;
using FluentAssertions;
using Microsoft.VisualBasic.CompilerServices;
using Xunit;

namespace ATOI;

public class Solution {
    public int MyAtoi(string input)
    {
        bool getIntegerChars = false;
        bool isNegative = false;
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            
            if (Char.IsWhiteSpace(currentChar))
            {
                if (getIntegerChars)
                {
                    break;
                }
                
                getIntegerChars = false;
            }
            else if (currentChar == '-')
            {
                if (getIntegerChars)
                {
                    break;
                }
                else
                {
                    isNegative = true;
                }
                
                getIntegerChars = !getIntegerChars;
            }
            else if (currentChar == '+')
            {
                if (getIntegerChars)
                {
                    break;
                }
                getIntegerChars = !getIntegerChars;
                
                continue;
            }
            else if (Char.IsDigit(currentChar))
            {
                getIntegerChars = true;
                sb.Append(currentChar);
            }
            else if (!Char.IsDigit(currentChar))
            {
                break;
            }
    
        }

        int? output = MyToInt(sb.ToString().ToCharArray());

        if (output == null)
        {
            if (isNegative)
            {
                return -2147483648;
            }

            return 2147483647;
        }

        if (isNegative)
            output = output * -1;
        
        
        return output.Value;
    }

    public int? MyToInt(char[] input)
    {
        double multiple = 1;
        double output = 0;
        
        foreach (char currentChar in input.Reverse())
        {
            Int32.TryParse(currentChar.ToString(), out int formattedInteger);
            output = (formattedInteger * multiple) + output;
            
            multiple = multiple * 10;
        }

        if (output > 2147483647)
        {
            return null;
        }
        
        return Convert.ToInt32(output);
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

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public void MyAtoi_Fact4()
    {
        Solution solution = new Solution();
        string input = "words and 987";
        int expectedOutput = 0;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact()]
    public void MyAtoi_Fact5()
    {
        Solution solution = new Solution();
        string input = "-91283472332";
        int expectedOutput = -2147483648;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact()]
    public void MyAtoi_Fact6()
    {
        throw new NotImplementedException("This needs to fail, just like in leetCode");
        Solution solution = new Solution();
        string input = "   +0 123";
        int expectedOutput = 0;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public async Task MyToInt_Fact1()
    {
        Solution solution = new Solution();
        char[] input = new []{'1'};
        int expectedOutput = 1;

        int output = solution.MyToInt(input).Value;
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public async Task MyToInt_Fact2()
    {
        Solution solution = new Solution();
        char[] input = new []{'1', '1'};
        int expectedOutput = 11;

        int output = solution.MyToInt(input).Value;
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public async Task MyToInt_Fact3()
    {
        Solution solution = new Solution();
        char[] input = new []{'1', '0', '0', '1'};
        int expectedOutput = 1001;

        int output = solution.MyToInt(input).Value;
        output.Should().Be(expectedOutput);
    }

    [Fact]
    public async Task MyToInt_Fact4()
    {
        Solution solution = new Solution();
        string input = "91283472332";
        
        int? output = solution.MyToInt(input.ToCharArray());
        output.Should().BeNull();
    }
    
    [Fact]
    public async Task MyToInt_Fact5()
    {
        Solution solution = new Solution();
        string input = "3.14159";
        int expectedOutput = 3;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public async Task MyToInt_Fact6()
    {
        Solution solution = new Solution();
        string input = "+1";
        int expectedOutput = 1;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public async Task MyToInt_Fact7()
    {
        Solution solution = new Solution();
        string input = "+-12";
        int expectedOutput = 0;

        int output = solution.MyAtoi(input);
        output.Should().Be(expectedOutput);
    }
    
    
}