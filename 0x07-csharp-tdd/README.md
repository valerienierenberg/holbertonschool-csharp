# 0x07. C# - Test Driven Development
- [Project Page](https://intranet.hbtn.io/projects/418)

## Learning Objectives
- What are solutions in VSCode
- How are solutions different from projects in VSCode
- What is a class library
- What is a unit test
- What are the benefits of unit testing
- How to create and run tests using NUnit
- What is the Arrange, Act, Assert methodology
- How to effectively name your unit tests
- How to utilize the TDD approach
- How to consider edge cases

## More Info
- Each task is one solution containing two projects: one class library solving the task and one test library to test the class library. For each task in this project:
    - Create task directory (ex: 0-add)
    - Inside that directory, run dotnet new sln
    - Create a new directory for your task solution based on the namespace given (ex: MyMath). This directory will hold your new standard class library.
    - Inside that directory, run dotnet new classlib. Rename the resulting .cs file after the namespace (ex: MyMath.cs)
    - Enable XML documentation by adding <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> to MyMath.csproj
        - The target framework for this standard class library should be netstandard2.0
    - Change directory back to the root directory of the task (ex: 0-add) and run dotnet sln add <classlibrary/classlibrary.csproj> (ex. dotnet sln add MyMath/MyMath.csproj)
    - Create a new directory for your tests based on the namespace given plus .Tests (ex: MyMath.Tests). This directory will hold your test library.
        - The target framework for this library should be netcoreapp2.1
    - Inside that directory, run dotnet new nunit. Rename the resulting .cs file after the namespace of classes you are testing plus .Tests (ex: MyMath.Tests.cs)
    - To add your class library as a dependency to the project, run dotnet add reference <../classlibrary/classlibrary.csproj> (ex: dotnet add reference ../MyMath/MyMath.csproj)
    - In the task’s root directory, run dotnet sln add <testlibrary/testlibrary.csproj (ex: dotnet sln add MyMath.Tests/MyMath.Tests.csproj)
    - If you’d like to run your class library method in a console application, create a new directory and run dotnet new console inside it. Run dotnet add reference <../classlibrary/classlibrary.csproj> and you can then call your class library methods inside the console application.
- The resulting directory hierarchy for task #0 will look like this:
```
/0-add
    0-add.sln
    /MyMath
        MyMath.cs
        MyMath.csproj
    /MyMath.Tests
        MyMath.Tests.cs
        MyMath.Tests.csproj
```
### If NUnit is not already installed, use the command: ```dotnet new -i NUnit3.DotNetNew.Template```

## Learning Objectives
- 0-add/, 0-add/0-add.sln, 0-add/MyMath, 0-add/MyMath/MyMath.csproj, 0-add/MyMath/MyMath.cs, 0-add/MyMath.Tests, 0-add/MyMath.Tests/MyMath.Tests.csproj, 0-add/MyMath.Tests/MyMath.Tests.cs
    - Write a method that adds 2 numbers
- 1-divide/, 1-divide/1-divide.sln, 1-divide/MyMath, 1-divide/MyMath/MyMath.csproj, 1-divide/MyMath/MyMath.cs, 1-divide/MyMath.Tests, 1-divide/MyMath.Tests/MyMath.Tests.csproj, 1-divide/MyMath.Tests/MyMath.Tests.cs
    - Write a method that divides all elements of a matrix.
- 2-max_int/, 2-max_int/2-max_int.sln, 2-max_int/MyMath, 2-max_int/MyMath/MyMath.csproj, 2-max_int/MyMath/MyMath.cs, 2-max_int/MyMath.Tests, 2-max_int/MyMath.Tests/MyMath.Tests.csproj, 2-max_int/MyMath.Tests/MyMath.Tests.cs
    - Write a method that returns the max integer in a list of integers.
- 3-palindrome/, 3-palindrome/3-palindrome.sln, 3-palindrome/Text, 3-palindrome/Text/Text.csproj, 3-palindrome/Text/Text.cs, 3-palindrome/Text.Tests/, 3-palindrome/Text.Tests/Text.Tests.csproj, 3-palindrome/Text.Tests/Text.Tests.cs
    - Write a method that returns True if a string is a palindrome or False if it’s not.
- 4-unique/, 4-unique/4-unique.sln, 4-unique/Text, 4-unique/Text/Text.csproj, 4-unique/Text/Text.cs, 4-unique/Text.Tests/, 4-unique/Text.Tests/Text.Tests.csproj, 4-unique/Text.Tests/Text.Tests.cs
    - Write a method that returns the index of the first non-repeating character of a string.
- 5-camelcase/, 5-camelcase/5-camelcase.sln, 5-camelcase/Text/, 5-camelcase/Text/Text.csproj, 5-camelcase/Text/Text.cs, 5-camelcase/Text.Tests/, 5-camelcase/Text.Tests/Text.Tests.csproj, 5-camelcase/Text.Tests/Text.Tests.cs
    - Write a method that determines how many words are in a string. Each word begins with a capital letter except the first word.
