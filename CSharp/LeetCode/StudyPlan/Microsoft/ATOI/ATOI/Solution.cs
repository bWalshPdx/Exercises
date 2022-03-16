using FluentAssertions;
using Xunit;

namespace ATOI;

public class Solution {
    public int MyAtoi(string s)
    {
        string noWhiteSpace = String.Concat(s.Where(c => !Char.IsWhiteSpace(c)));
        
        return Int32.Parse(noWhiteSpace);
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
}