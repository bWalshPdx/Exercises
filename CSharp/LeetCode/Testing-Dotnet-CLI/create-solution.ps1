$solutionName = "LeetCodeTemplate"

dotnet new sln -o $solutionName

dotnet new classlib -o $solutionName

dotnet sln $solutionName\$solutionName.sln add .\$solutionName\$solutionName.csproj