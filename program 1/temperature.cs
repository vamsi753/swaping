using System;

class temperatureProgram
{
    static void Main()
    {
        Console.Write("Enter the amount of celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double kelvin = celsius + 273.15;
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"Kelvin = {kelvin:F0}");
        Console.WriteLine($"Fahrenheit = {fahrenheit:F0}");
    }
}
