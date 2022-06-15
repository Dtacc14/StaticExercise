using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the fahrenheit temp you would like to convert to celcius?");
            double fah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"That turns to {TempConverter.FahrenheitToCelsius(fah)} degrees celcius");
            Console.WriteLine();                                                                              // Refactored after review
            Console.WriteLine("What is the celcius temp you would like to convert to fahrenheit?");
            double cel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"That turns to {TempConverter.CelsiusToFahrenheit(cel)} degrees fahrenheit.");
        }
    }
}
