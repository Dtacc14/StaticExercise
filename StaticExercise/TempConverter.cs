using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit) // Made changes aftter exercise review
        {
            double celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }
        public static double CelsiusToFahrenheit(double celcius)     // Made changes after exercise review
        {
            double fahrenheit = (celcius * 1.8) + 32;
            return fahrenheit;
        }
    }
}

