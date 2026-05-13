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
        //10.Bài 13. Rectangle Pattern with Number
        Console.Write("Enter a number: ");
        int nb = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{0}{0}", nb);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("{0} {0}", nb);
        }
        Console.WriteLine("{0}{0}{0}", nb);

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

    }
    