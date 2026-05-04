using System;

class Program
{
    // 1. Declare delegate
    public delegate double Converter(double temp);

    // 2. Conversion methods
    public static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static void Main(string[] args)
    {
        // Ask for temperature
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // Ask for conversion choice
        Console.WriteLine("Choose conversion:");
        Console.WriteLine("1 → Celsius to Fahrenheit");
        Console.WriteLine("2 → Fahrenheit to Celsius");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Declare delegate variable
        Converter convert;

        // Assign method based on choice
        if (choice == 1)
        {
            convert = CelsiusToFahrenheit;
        }
        else if (choice == 2)
        {
            convert = FahrenheitToCelsius;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        // Perform conversion using delegate
        double result = convert(temperature);

        // Display result
        Console.WriteLine("Converted temperature: " + result);
    }
}