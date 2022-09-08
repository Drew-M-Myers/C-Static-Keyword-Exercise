using StaticKeywordExercise;
using System;

namespace StaticKeyWordExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(212);
            Console.WriteLine($"Celsius: {celsius}");
            Console.WriteLine("");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine($"Fahrenheit: {fahrenheit}"); 
        }
    }
}