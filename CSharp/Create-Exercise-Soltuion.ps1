$SolutionName = 'Test-Solution'
mkdir $SolutionName
cd $SolutionName
dotnet new sln -n $SolutionName
dotnet new classlib -o $SolutionName
dotnet new xunit -o "$SolutionName.Test"
dotnet sln $SolutionName.sln add $SolutionName\$SolutionName.csproj
dotnet sln $SolutionName.sln add "$SolutionName.Test\$SolutionName.Test.csproj"
cd ..
