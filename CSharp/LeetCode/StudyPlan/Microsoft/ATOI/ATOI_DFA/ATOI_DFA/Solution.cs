using FluentAssertions;
using Xunit;

namespace ATOI_DFA;

public class Solution
{
    public int MyAtoi(string input)
    {
        return 0;
    }
}



public class Solution_Tests
{
    [Fact]
    public async Task Bootstrap()
    {
        Solution solution = new Solution();
        string input = "";
        int expectedOutput = 0;

        int output = solution.MyAtoi("");

        output.Should().Be(expectedOutput);
    }
}