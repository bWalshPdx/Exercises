
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> parenStack = new Stack<char>();
        Stack<char> bracketStack = new Stack<char>();
        char[] splitUpInput = s.ToCharArray();

        foreach (var currentChar in splitUpInput)
        {
            if (currentChar == '(')
                parenStack.Push('(');
            else if (currentChar == ')')
            {
                if (!parenStack.Any())
                {
                    return false;
                }
                parenStack.Pop();
            }
            else if (currentChar == '[')
                bracketStack.Push('[');
            else if (currentChar == ']')
            {
                if (!bracketStack.Any())
                {
                    return false;
                }
                
                bracketStack.Pop();
            }
                            
        }

        return !parenStack.Any() && !bracketStack.Any();
    }

}

public class Solution_Test
{
    [Fact]
    public void Paren_Fact1()
    {
        Solution s = new Solution();

        string input = "()";
        bool expectedOutput = true;
        
        bool output = s.IsValid("");

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void Paren_Fact2()
    {
        Solution s = new Solution();

        string input = "((";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void Paren_Fact3()
    {
        Solution s = new Solution();

        string input = "((())";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void Bracket_Fact1()
    {
        Solution s = new Solution();

        string input = "[]";
        bool expectedOutput = true;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void Bracket_Fact2()
    {
        Solution s = new Solution();

        string input = "[[";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void BracketAndParen_Fact1()
    {
        Solution s = new Solution();

        string input = "[()]";
        bool expectedOutput = true;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void BracketAndParen_Fact2()
    {
        Solution s = new Solution();

        string input = "[()]]";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
}

