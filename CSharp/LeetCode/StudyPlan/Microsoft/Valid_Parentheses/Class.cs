
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> parenStack = new Stack<char>();
        char[] splitUpInput = s.ToCharArray();

        foreach (var currentParen in splitUpInput)
        {
            if (currentParen == '(')
                parenStack.Push('(');

            if (parenStack.Any() && currentParen == ')')
                parenStack.Pop();
        }

        return !parenStack.Any();
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
}

