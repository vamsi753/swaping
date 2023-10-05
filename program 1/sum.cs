using System;

class sumProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        if (num1 == num2)
        {
            int tripleSum = 3 * sum;
            Console.WriteLine($"The two numbers are equal, so the triple of their sum is: {tripleSum}");
        }
        else
        {
            Console.WriteLine($"The sum of the two numbers is: {sum}");
        }
    }
}
