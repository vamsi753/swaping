using System;

class calculatorProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;

        Console.WriteLine($"Sum: {num1} + {num2} = {sum}");
        Console.WriteLine($"Difference: {num1} - {num2} = {difference}");
        Console.WriteLine($"Product: {num1} * {num2} = {product}");

        if (num2 != 0)
        {
            Console.WriteLine($"Quotient: {num1} / {num2} = {quotient}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
