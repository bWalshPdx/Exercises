$solutionName = "LeetCodeTemplate"

dotnet new sln -o $solutionName

dotnet new classlib -o $solutionName
dotnet sln $solutionName.sln add .\$solutionName\$solutionName.csproj

# dotnet add .\MyWebApp.Client\MyWebApp.Client.csproj reference .\MyWebApp.DataStore\MyWebApp.DataStore.csproj
# dotnet add .\MyWebApp.DataStoreTest\MyWebApp.DataStoreTest.csproj reference .\MyWebApp.DataStore\MyWebApp.DataStore.csproj