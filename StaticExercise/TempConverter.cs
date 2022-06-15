using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double Fahrenheit { get; set; }
        public static double Celcius { get; set; }
        public static double FahrenheitToCelsius()
        {
            double fahrenheit = Fahrenheit;
            double celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }
        public static double CelsiusToFahrenheit()
        {
            double celcius = Celcius;
            double fahrenheit = (celcius * 1.8) + 32;
            return fahrenheit;
        }
    }
}

