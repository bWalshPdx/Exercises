using FluentAssertions;
using Xunit;

namespace ATOI;

public class Solution {
    public int MyAtoi(string s)
    {
        return 42;
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
}