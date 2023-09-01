<#
.SYNOPSIS
Creates a folder with optional note file and mindmap
.DESCRIPTION
Creates a folder with optional note file and mindmap
#>
[CmdletBinding(SupportsShouldProcess=$true, ConfirmImpact='High')]
Param(
    [Parameter(Mandatory=$true)]
    [string]$solutionName,

    [Parameter(Mandatory=$true)]
    [string]$solutionLink
)

if($solutionName.Length -eq 0) 
{
    throw "Solution Name is null"
}


if($solutionLink.Length -eq 0)
{
    throw "Solution Link is null"
}

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
### What are the best aspects of the design of the code I’ve ended up with?


### In what ways did I do Test Driven Development particularly well?


### Did I learn anything new?


### Did anything unexpected happen?


### What do I still need to practice more?


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
