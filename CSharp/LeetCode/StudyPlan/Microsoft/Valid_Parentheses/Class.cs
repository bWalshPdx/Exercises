
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution {
    public bool IsValid(string s) {
        return true;
    }
}

public class Solution_Test
{
    [Fact]
    public void Boilerplate()
    {
        Solution s = new Solution();
        bool output = s.IsValid("");

        output.Should().BeTrue();
    }
}

