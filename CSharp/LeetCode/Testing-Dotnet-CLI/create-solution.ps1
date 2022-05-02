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

## Prepping for writing the Solution

### Rules of the Problem:

### Proposed tests for each rule:

## Reflection:
### What are the best aspects of the design of the code we’ve ended up with?


### In what ways did we do Test Driven Development particularly well?


### Did we learn anything new?


### Did anything unexpected happen?


### What do we still need to practice more?


### What should you do differently in the next exercise?
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
