
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    enum ParenType
    {
        Paren,
        Curly,
        Bracket
    }
    
    Stack<char> parenStack = new Stack<char>();
    Stack<char> bracketStack = new Stack<char>();
    Stack<char> curlyBracketStack = new Stack<char>();
    
    private ParenType lastOpenParen;
    
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
                        PushToStack(currentChar);
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

        return AllStacksAreEmpty();
    }

    public bool AllStacksAreEmpty()
    {
        return !parenStack.Any() && !bracketStack.Any() && !curlyBracketStack.Any();
    }

    public void PushToStack(char input)
    {
        switch (input)
        {
            case '(':
                parenStack.Push('(');
                lastOpenParen = ParenType.Curly;
                break;
            case '[':
                bracketStack.Push('[');
                lastOpenParen = ParenType.Bracket;
                break;
            case '{':
                curlyBracketStack.Push('{');
                lastOpenParen = ParenType.Curly;
                break;
        }
    }
    
    public void PopFromStack(char input)
    {
        switch (input)
        {
            case ')':
                if (!parenStack.Any() || lastOpenParen != ParenType.Curly)
                    throw new ArgumentException("Stack is empty, cannot pop");
                parenStack.Pop();
                break;
            case ']':
                if (!bracketStack.Any() || lastOpenParen != ParenType.Bracket)
                    throw new ArgumentException("Stack is empty, cannot pop");
                bracketStack.Pop();
                break;
            case '}':
                if (!curlyBracketStack.Any() || lastOpenParen != ParenType.Curly)
                    throw new ArgumentException("Stack is empty, cannot pop");
                curlyBracketStack.Pop();
                break;
            default:
                throw new ArgumentException("Paren given not found");
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

