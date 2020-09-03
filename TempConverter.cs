using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrTemp)
        {
            double celsTemp = (fahrTemp - 32) / 1.8;
            return Math.Round(celsTemp, 1);
        }

        public static double CelsiusToFahrenheit(double celsTemp)
        {
            double fahrTemp = (celsTemp * 1.8) + 32;
            return Math.Round(fahrTemp, 1);
        }
    }
}
