using System;
public class Program
{
    public static void Main()
    {
        //Cho phép gõ tiếng Việt có dấu
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //Print Hello and Name
        //printName();

        //Specified Operations Results
        //operationResults();

        //Multiply Three Numbers
        //multiplyThreeNumbers();

        //Arithmetic Operations
        //arithmeticOperation();

        //Multiplication Table
        //multiplicationTable();

        //Average of Four Numbers
        //averageOfFourNumbers();

        //Specified Formula with Three Numbers: (x+y).z and x.y + y.z.
        //specifiedFormula();

        //Print Age Message
        //printAgeMessage();

        //Repeat Number in Rows
        //repeatNumberInRows();

        //Rectangle Pattern with Number
        //rectanglePatternWithNumber();

        //Remove Character by Index
        //removeCharacter();

        //Swap First and Last Characters
        //swapFirstAndLastChar();

        //Add First Character to Front and Back
        //addFirstCharToFrontAndBack();

        //Check Positive and Negative Pair
        //checkPositiveNegativePair();

        //Sum or Triple Sum of Integers
        sumOrTripleSumOfIntegers();



    }
    public static string printName()
    {
        Console.Write("Input your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        return name;
    }
    public static void operationResults()
    {
        int result1 = -1 + 4 * 6;
        int result2 = (35 + 5) % 7;
        int result3 = 14 + -4 * 6 / 11;
        int result4 = 2 + 15 / 6 * 1 - 7 % 2;

        Console.WriteLine($"-1 + 4 * 6 = {result1}");
        Console.WriteLine($"(35 + 5) % 7 = {result2}");
        Console.WriteLine($"14 + -4 * 6 / 11 = {result3}");
        Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {result4}");
    }
    public static void multiplyThreeNumbers()
    {
        Console.Write("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        int num3 = int.Parse(Console.ReadLine());
        int result = num1 * num2 * num3;
        Console.WriteLine($"The result of multiplying {num1}, {num2}, and {num3} is {result}");
    }
    public static void arithmeticOperation()
    {
        Console.Write("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        int subtract = num1 - num2;
        int multiply = num1 * num2;
        int divide = num1 / num2;
        int modulus = num1 % num2;
        Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
        Console.WriteLine($"Difference of {num1} and {num2} is: {subtract}");
        Console.WriteLine($"Product of {num1} and {num2} is: {multiply}");
        Console.WriteLine($"Quotient of {num1} and {num2} is: {divide}");
        Console.WriteLine($"Remainder of {num1} and {num2} is: {modulus}");
    }
    public static void multiplicationTable()
    {
        Console.Write("Input a number to display its multiplication table: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Multiplication Table of {num}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
    public static void averageOfFourNumbers()
    {
        Console.Write("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.Write("Input fourth number: ");
        int num4 = int.Parse(Console.ReadLine());
        double average = (num1 + num2 + num3 + num4) / 4.0;
        Console.WriteLine($"The average of {num1}, {num2}, {num3}, and {num4} is {average}");
    }
    public static void specifiedFormula()
    {
        Console.Write("Input x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Input z: ");
        int z = int.Parse(Console.ReadLine());
        int result1 = (x + y) * z;
        int result2 = (x * y) + (y * z);
        Console.WriteLine($"(x + y) * z = {result1}");
        Console.WriteLine($"x * y + y * z = {result2}");
    }
    public static void printAgeMessage()
    {
        Console.Write("Input your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("You look younger than your age.");
    }
    public static void repeatNumberInRows()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);
        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);
    }
    public static void rectanglePatternWithNumber()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());
        int rows = 5;
        int columns = 3;
        for (int i = 1; i <= rows; i++)
        {
            if (i == 1 || i == rows)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write(num);
                }
            }
            else
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (j == 1 || j == columns)
                    {
                        Console.Write(num);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
            }

            Console.WriteLine();
        }

    }
    public static void removeCharacter()
    {
        string str = "w3resource";
        string str1 = str.Remove(1, 1);
        string str2 = str.Remove(9, 1);
        string str3 = str.Remove(0, 1);
        Console.WriteLine($"Original string: {str}");
        Console.WriteLine("After removing characters:");
        Console.WriteLine($"Remove character at index 1: {str1}");
        Console.WriteLine($"Remove character at index 9: {str2}");
        Console.WriteLine($"remove character at index 0: {str3}");
    }
    public static void swapFirstAndLastChar()
    {
        string str = "w3resource";

        char firstChar = str[0];
        char lastChar = str[str.Length - 1];
        string middlePart = str[1..^1];
        string swappedStr = lastChar + middlePart + firstChar;
        Console.WriteLine($"Original string: {str}");
        Console.WriteLine($"String after swapping first and last characters: {swappedStr}");
    }
    public static void addFirstCharToFrontAndBack()
    {
        string str = "The quick brown fox jumps over the lazy dog.";
        char firstChar = str[0];
        string result = firstChar + str + firstChar;
        Console.WriteLine($"String after adding first character to front and back: {result}");
    }
    public static void checkPositiveNegativePair()
    {
        Console.Write("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
        if ((num1 > 0 && num2 < 0) || (num1 < 0 && num2 > 0))
        {
            Console.WriteLine("The numbers are a positive and negative pair.");
        }
        else
        {
            Console.WriteLine("The numbers are not a positive and negative pair.");
        }
    }

    public static void sumOrTripleSumOfIntegers()
    {
        Console.Write("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 == num2)
        {
            int tripleSum = 3 * (num1 + num2);
            Console.WriteLine($"The numbers are equal. Triple of their sum is: {tripleSum}");
        }
        else
        {
            int sum = num1 + num2;
            Console.WriteLine($"The numbers are not equal. Their sum is: {sum}");
        }
    }

}
    