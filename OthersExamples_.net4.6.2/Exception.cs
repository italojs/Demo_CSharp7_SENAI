using System;

namespace OthersExamples_.net4._6._2
{
    public static class ExceptionTemperature
    {
        private static double _celsius;

        public static double Celsius
        {
            get => _celsius;
            set => _celsius = value >= -273.15 ? value : throw new Exception("Temperatura inválida!");
        }

        public static double Fahrenheit
        {
            get => ((9.0 / 5.0) * _celsius) + 32;
        }
    }
}