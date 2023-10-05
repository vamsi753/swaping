using System;

class differenceProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double difference = Math.Abs(num1 - num2);

        if (num1 > num2)
        {
            double doubleDifference = 2 * difference;
            Console.WriteLine($"The first number is greater, so double the absolute difference is: {doubleDifference}");
        }
        else
        {
            Console.WriteLine($"The absolute difference between the two numbers is: {difference}");
        }
    }
}
