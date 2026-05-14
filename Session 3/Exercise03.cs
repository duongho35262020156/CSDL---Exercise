using System;
public class Program
{
    public static void Main()
    {
        //performs an operation(+, -, *, x,/)
        //performOperation();

        //x = y2 + 2y + 1(using integer numbers for y, ranging from - 5 to + 5).
        //calculateY();

        //takes distance and time(hours, minutes, seconds) as input and displays speed in kilometers per hour(km / h) and miles per hour(miles/ h).
        //calculateSpeed();

        //the surface and volume of the sphere.  V = 4/3*π*r3 
        //calculateSphere();

        //checks if it is a vowel, a digit, or any other symbol.
        checkInputChar();
    }
    public static void performOperation()
    {
        Console.Write("Input first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        int number2 = int.Parse(Console.ReadLine());
        int sum = number1 + number2;
        int product = number1 * number2;
        int difference = number1 - number2;
        int quotient = number1 / number2;
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The product is: " + product);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The quotient is: " + quotient);
    }
    public static void calculateY()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"For y = {y}, x = {x}");
        }
    }
    public static void calculateSpeed()
    {
        Console.Write("Input distance in kilometers:");
        double distance = double.Parse(Console.ReadLine());
        Console.Write("Input time in hours:");
        double hours = double.Parse(Console.ReadLine());
        Console.Write("Input time in minutes:");
        double minutes = double.Parse(Console.ReadLine());
        Console.Write("Input time in seconds:");
        double seconds = double.Parse(Console.ReadLine());
        double totalHours = hours + (minutes / 60) + (seconds / 3600);
        double speedKmh = distance / totalHours;
        double speedMph = speedKmh * 0.621371;
        Console.WriteLine($"Speed in km/h: {speedKmh}");
        Console.WriteLine($"Speed in miles/h: {speedMph}");
    }
    public static void calculateSphere()
    {
        Console.Write("Input radius of the sphere:");
        double radius = double.Parse(Console.ReadLine());
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Surface area of the sphere: {surfaceArea:F2}");
        Console.WriteLine($"Volume of the sphere: {volume:F2}");
    }
    public static void checkInputChar()
    {
        Console.Write("Input a character:");
        char inputChar = Console.ReadKey().KeyChar;
        char lowerChar = Char.ToLower(inputChar);
        Console.WriteLine();
        if (lowerChar == 'u' || lowerChar == 'e' || lowerChar == 'o' || lowerChar == 'a' || lowerChar == 'i')
        {
            Console.WriteLine("It is a vowel.");
        }
        else if (Char.IsDigit(lowerChar))
        {
            Console.WriteLine("It is a digit.");
            
        }
        else
        {
            Console.WriteLine("It is a symbol.");
        }
    }
}