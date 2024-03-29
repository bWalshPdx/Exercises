
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {

    Stack<char> parenStack = new Stack<char>();
    
    public bool IsValid(string s)
    {
        char[] splitUpInput = s.ToCharArray();

        try
        {
            foreach (var currentChar in splitUpInput)
            {
                switch (currentChar)
                {
                    case '(':
                    case '[':
                    case '{':
                        parenStack.Push(currentChar);
                        break;
                    case ')':
                    case ']':
                    case '}':
                        PopFromStack(currentChar);
                        break;
                }                
            }
        }
        catch (Exception e)
        {
            return false;
        }

        return !parenStack.Any();
    }
    
    public void PopFromStack(char input)
    {
        char openParen;
        switch (input)
        {
            case ')':
                CheckAndPop('(');
                break;
            case ']':
                CheckAndPop('[');    
                break;
            case '}':
                CheckAndPop('{');
                break;
            default:
                throw new ArgumentException("Paren given not found");
        }
    }

    public void CheckAndPop(char openParenToCheck)
    {
        if (!parenStack.Any())
        {
            throw new ArgumentException("Stack is empty, cannot pop");
        }
                
        char openParen = parenStack.Pop();
                
        if (openParen != openParenToCheck)
        {
            throw new ArgumentException("Paren mismatch");
        }
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
    
    //()[]{}
    [Fact]
    public void LeetCodeExample_Fact1()
    {
        Solution s = new Solution();

        string input = "()[]{}";
        bool expectedOutput = true;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void LeetCodeExample_Fact2()
    {
        Solution s = new Solution();

        string input = "()[]{}}";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void LeetCodeExample_Fact3()
    {
        Solution s = new Solution();

        string input = "(]";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void LeetCodeExample_Fact4()
    {
        Solution s = new Solution();

        string input = "([)]";
        bool expectedOutput = false;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
    
    [Fact]
    public void LeetCodeExample_Fact5()
    {
        
        Solution s = new Solution();

        string input = "{[]}";
        bool expectedOutput = true;
        
        bool output = s.IsValid(input);

        output.Should().Be(expectedOutput);
    }
}

