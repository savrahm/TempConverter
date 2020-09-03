using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(20));
            Console.WriteLine(TempConverter.FahrenheitToCelsius(80));
        }
    }
}
