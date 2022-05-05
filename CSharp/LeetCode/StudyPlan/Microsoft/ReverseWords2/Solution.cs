
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public void ReverseWords(char[] s) {
        //s = new[]{'d', 'r', 'o', 'w'};
        
        s[0] = 'd';
        s[1] = 'r';
        s[2] = 'o';
        s[3] = 'w';
    }
}

public class Solution_Test
{
    [Fact]
    public void ReverseWords_SingleWordShouldBeReversed()
    {
        Solution s = new Solution();
        char[] input = {'w', 'o', 'r', 'd'}; 
        char[] expectedOutput = {'d', 'r', 'o', 'w'};
        
        s.ReverseWords(input);
        input.Should().Equal(expectedOutput);
    }
}

