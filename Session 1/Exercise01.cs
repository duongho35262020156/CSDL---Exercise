using System;
public class Program
{
    public static void Main()
    {
        //to Add / Sum Two Numbers.
        Console.Write("Input first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
                int sum = num1 + num2;
        Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");

        //to Swap Values of Two Variables.
        int a = 7; int b = 5;
        Console.WriteLine($"Before swapping a = {a}, b = {b}");
        int temp = a; a = b; b = temp;
        Console.WriteLine($"After swapping a = {a}, b = {b}");

        //to Multiply two Floating Point Numbers
        float f1 = 1.5f, f2 = 2.5f;
        Console.WriteLine($"Multiply two Floating Point Numbers {f1} * {f2} is: {f1 * f2}");

        //to convert feet to meter
        float feet = 10.05f;
        float meter = 0.3048f * feet;
        Console.WriteLine($"Convert feet to meter: {feet} feet = {meter} meters");

        //to convert Celsius to Fahrenheit and vice versa
        float celsius = 25.0f;
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Convert Celsius to Fahrenheit: {celsius} Celsius = {fahrenheit} Fahrenheis");

        float F1 = 77.0f;
        float C1 = (F1 - 32) * 5 / 9;
        Console.WriteLine($"Convert Fahrenheit to us Celsius :{F1} Fahrenheis={C1} Celsius");

        //to find the Size of data types
                Console.WriteLine($"Size of int: {sizeof(int)} bytes");
                Console.WriteLine($"Size of float: {sizeof(float)} bytes");
                Console.WriteLine($"Size of double: {sizeof(double)} bytes");
                Console.WriteLine($"Size of char: {sizeof(char)} bytes");
                Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");

        //to Print ASCII Value
        Console.Write("Input a character: ");
        char ch = Console.ReadLine()[0];
        int ascii = (int)ch;
        Console.WriteLine($"The ASCII value of {ch} is: {ascii}");

        //to find the Area of a Circle
                Console.Write("Input the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine($"The area of the circle with radius {radius} is: {area}");

        //to find the Area of a Square
        Console.Write("Input the side length of the square: ");
        double side = double.Parse(Console.ReadLine());
        double squareArea = side * side;
        Console.WriteLine($"The area of the square with side length {side} is: {squareArea}");

        //to convert days to years, weeks and days
        Console.Write("Input number of days: ");
        int totalDays = int.Parse(Console.ReadLine());
                int years = totalDays / 365;   
                int remainingDaysAfterYear = totalDays % 365;
                int weeks = remainingDaysAfterYear / 7;
                int days = remainingDaysAfterYear % 7;
        Console.WriteLine($"{totalDays} days = {years} years, {weeks} weeks, and {days} days");
    }
}
