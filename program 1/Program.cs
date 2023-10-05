using System;

class Program
{
    static void Main()
    {
        double firstNumber, secondNumber, temp;

        Console.Write("Enter the first number: ");
        firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        secondNumber = Convert.ToDouble(Console.ReadLine());

        
        temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + firstNumber);
        Console.WriteLine("Second number: " + secondNumber);
    }
}
