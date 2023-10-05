using System;

class testProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        double z = Convert.ToDouble(Console.ReadLine());

        double result1 = (x + y) * z;
        double result2 = x * y + y * z;

        Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
    }
}
