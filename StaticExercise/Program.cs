using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempConverter.Fahrenheit = 59;
            Console.WriteLine(TempConverter.FahrenheitToCelsius());
            Console.WriteLine();

            TempConverter.Celcius = 15;
            Console.WriteLine(TempConverter.CelsiusToFahrenheit());
        }
    }
}
