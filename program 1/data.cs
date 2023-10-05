using System;

class dataProgram
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Display the number four times with spaces
        Console.WriteLine("{0} {0} {0} {0}", number);

        // Display the number four times without spaces
        Console.WriteLine("{0}{0}{0}{0}", number);

        // Repeat the process
        Console.WriteLine("{0} {0} {0} {0}", number);
        Console.WriteLine("{0}{0}{0}{0}", number);
    }
}
