using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSENAI_CSharp7
{
    public static class Tuple
    {
        public static void Exemple1()
        {
            //the tuple accept multiples types like (int,string,object)
            (int, int) twoValues = (7, 49);
            Console.WriteLine($"Value 1 = {twoValues.Item1} - " +
                                  $"Value 2 = {twoValues.Item2}");

            (int, int, int) Dozens = (10, 20, 30);
            Console.WriteLine($"Dozen 1 = {Dozens.Item1} - " +
                                  $"Dozen 2 = {Dozens.Item2} - " +
                                  $"Dozen 3 = {Dozens.Item3}");

            var latLong = (latitude: "23.5505° S", longitude: "46.6333° W");
            Console.WriteLine($"São Paulo - " +
                                  $"Lat = {latLong.latitude} - " +
                                  $"Long = {latLong.longitude}");

        }

        public static void Example2()
        {
            Console.WriteLine("Converting temperatures");

            // Exemple 1
            var res1 = ConvertTemperature(86);
            //getting the tuple value return
            Console.WriteLine($"Fahrenheit = {res1.tempFahrenheit} - " +
                              $"Celsius = {res1.tempCelsius} - " +
                              $"Kelvin = {res1.tempKelvin}");

            // Exemplo 2 - setting the return to others variables
            (double resFahrenheit2, double resCelsius2, double resKelvin2) = ConvertTemperature(32);
            Console.WriteLine($"Fahrenheit = {resFahrenheit2} - " +
                              $"Celsius = {resCelsius2} - " +
                              $"Kelvin = {resKelvin2}");

            // Exemplo 2 - discarting a value with _ of this return
            double ValueFahrenheit3 = 212;
            (_, double resCelsius3, double resKelvin3) = ConvertTemperature(ValueFahrenheit3);
            Console.WriteLine($"Fahrenheit = {ValueFahrenheit3} - " +
                              $"Celsius = {resCelsius3} - " +
                              $"Kelvin = {resKelvin3}");

        }

        //return a tuple
        private static (double tempFahrenheit, double tempCelsius, double tempKelvin) ConvertTemperature(double ValueFahrenheit)
        {
            double retCelsius = Math.Round((ValueFahrenheit - 32) / 1.8, 2);
            double retKelvin = retCelsius + +273.15;

            //returning a tuple 
            return (ValueFahrenheit, retCelsius, retKelvin);
        }
    }
}
