$solutionName = "LeetCodeTemplate"
$solutionLink = "https://www.google.com/"

$classContents = "
using FluentAssertions;
using Xunit;
namespace LeetCodeTemplate;

public class Solution
{

}

public class Solution_Test
{
    [Fact]
    public void Boilerplate()
    {
        Solution s = new Solution();
        s.Should().NotBeNull();
    }
}
"

$readme = "
# $solutionName
-------------------------
Leetcode description:
$solutionLink
"


dotnet new sln -o $solutionName

dotnet new classlib -o $solutionName

dotnet sln $solutionName\$solutionName.sln add .\$solutionName\$solutionName.csproj

cd $solutionName


dotnet add package xunit
dotnet add package FluentAssertions
dotnet add package Microsoft.NET.Test.Sdk

echo $classContents > Class.cs
rm Class1.cs

echo $readme > README.md

cd ..
