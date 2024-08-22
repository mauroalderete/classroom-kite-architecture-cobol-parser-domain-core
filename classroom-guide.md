# Classroom Guide

## Steps

### Prepare the repository

1. Create a new repository on GitHub.
2. Clone the repository to your local machine.
4. Create a new branch.
3. Add:
   1. Issue templates
   2. Readme
   3. CSharp gitignore based file
4. Create PR

### Create dotnet Solution

1. Create a new solution in Visual Studio.

```bash
dotnet new sln -n CobolParser.Domain.Core
```

2. Create a new classlib project in the solution.

```bash
dotnet new classlib -n CobolParser.Domain.Core -o CobolParser.Domain.Core
```

3. Create a new unit test project in the solution with MSTest.

```bash
dotnet new mstest -n CobolParser.Domain.Core.UnitTests -o CobolParser.Domain.Core.UnitTests
```

4. Add the projects to the solution.

```bash
dotnet sln add CobolParser.Domain.Core/CobolParser.Domain.Core.csproj
dotnet sln add CobolParser.Domain.Core.UnitTests/CobolParser.Domain.Core.UnitTests.csproj
```

5. Restore the solution.

```bash
dotnet restore
```
