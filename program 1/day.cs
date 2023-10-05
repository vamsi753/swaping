using System;

class dayProgram
{
    static void Main()
    {
        Console.Write("Enter the number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        int years = days / 365;
        int weeks = (days % 365) / 7;
        int remainingDays = (days % 365) % 7;

        Console.WriteLine($"Years: {years}");
        Console.WriteLine($"Weeks: {weeks}");
        Console.WriteLine($"Days: {remainingDays}");
    }
}
