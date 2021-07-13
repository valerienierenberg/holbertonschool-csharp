# 0x01. C# - if/else, loops, functions

## Learning Objectives

- How to use if, else if, else statements
- How to use while and for loops
- How to use break and continue statements
- How to use numeric format strings
- How to declare methods within a class
- How to call public methods from another class
- What is passing by reference and passing by value


## Task Descriptions

- 0-positive_or_negative/, 0-positive_or_negative/0-positive_or_negative.csproj, 0-positive_or_negative/0-positive_or_negative.cs : program that assigns a random signed number to the variable number each time it is executed.
- 1-last_digit/, 1-last_digit/1-last_digit.csproj, 1-last_digit/1-last_digit.cs : program will assign a random signed number to the variable number each time it is executed. Then, the script prints whether the last digit of the number stored in the variable number is positive or negative.
- 2-print_alphabet/, 2-print_alphabet/2-print_alphabet.csproj, 2-print_alphabet/2-print_alphabet.cs : Write a program that prints the alphabet, in lowercase, not followed by a new line.
    - You can only use Console.Write once
    - You can only use one loop in your code
- 3-print_alphabt/, 3-print_alphabt/3-print_alphabt.csproj, 3-print_alphabt/3-print_alphabt.cs : program that prints the alphabet, in lowercase, not followed by a new line.
    - Print all the letters except q and e
    - You can only use Console.Write once
    - You can only use one loop in your code
- 4-print_hexa/, 4-print_hexa/4-print_hexa.csproj, 4-print_hexa/4-print_hexa.cs : program that prints all numbers from 0 to 98 in decimal and in hexadecimal (as in the following example)
    - You can only use Console.Write once
    - You can only use one loop in your code
- 5-print_comb/, 5-print_comb/5-print_comb.csproj, 5-print_comb/5-print_comb.cs : program that prints numbers from 0 to 99.
    - Numbers must be separated by ,, followed by a space
    - Numbers should be printed in ascending order, with two digits
    - The last number should be followed by a new line
    - You can only use Console.Write no more than twice
    - You can only use one loop in your code
- 6-print_comb2/, 6-print_comb2/6-print_comb2.csproj, 6-print_comb2/6-print_comb2.cs : program that prints all possible different combinations of two digits.
    - Numbers must be separated by ,, followed by a space
    - The two digits must be different
    - 01 and 10 are considered the same combination of the two digits 0 and 1
    - Print only the smallest combination of two digits
    - Numbers should be printed in ascending order, with two digits
    - The last number should be followed by a new line
    - You can only use Console.Write and Console.WriteLine no more than three times total
    - You can only use no more than 2 loops in your code
- 7-islower/, 7-islower/7-islower.csproj, 7-islower/7-islower.cs : method that checks for lowercase character.
    - Class Name: class Character
    - Prototype: public static bool IsLower(char c)
    - Returns True if c is lowercase
    - Returns False otherwise
    - You are not allowed to use Char.IsLower() or Char.IsUpper()
- 8-print_last_digit/, 8-print_last_digit/8-print_last_digit.csproj, 8-print_last_digit/8-print_last_digit.cs : method that prints the last digit of a number.
    - Class Name: class Number
    - Prototype: public static int PrintLastDigit(int number)
    - Returns the value of the last digit
- 9-add/, 9-add/9-add.csproj, 9-add/9-add.cs : method that adds two integers and returns the result.
    - Class Name: class Number
    - Prototype: public static int Add(int a, int b)
    - Returns the value of a + b
- 10-print_line/, 10-print_line/10-print_line.csproj, 10-print_line/10-print_line.cs : method that draws a straight line in the terminal.
    - Class Name: class Line
    - Prototype: public static void PrintLine(int length)
    - Where length is the number of times the character _ should be printed
    - The line should end with a new line
    - If length is 0 or less, the function should only print a new line
- 11-print_diagonal/, 11-print_diagonal/11-print_diagonal.csproj, 11-print_diagonal/11-print_diagonal.cs : method that draws a diagonal line in the terminal.
    - Class Name: class Line
    - Prototype: public static void PrintDiagonal(int length)
    - Where length is the number of times the character \ should be printed
    - The line should end with a new line
    - If length is 0 or less, the function should only print a new line
- 12-fizzbuzz/, 12-fizzbuzz/12-fizzbuzz.csproj, 12-fizzbuzz/12-fizzbuzz.cs : program that prints the numbers from 1 to 100 separated by a space.
    - For multiples of three print Fizz instead of the number and for multiples of five print Buzz.
    - For numbers which are multiples of both three and five print FizzBuzz.
    - Each element should be followed by a space
    - The last element should be followed by a new line
