using System;

namespace OthersExamples_.net4._6._2
{
    public static class PatternMatching
    {

        public static void Example(ExchangeRate exchangeRate)
        { 
                switch (exchangeRate)
                {
                    case DollarExchangeRate dollar when (dollar.TurismValue <= 3):
                        Console.WriteLine("Hora de viajar para o EUA!");
                        break;
                    case DollarExchangeRate dollar when (dollar.TurismValue > 3):
                        Console.WriteLine("Melhor ficar em casa!");
                        break;
                    case EuroExchangeRate euro when (euro.ExchangeRateValue <= 3):
                        Console.WriteLine("Hora de viajar para Europa!");
                        break;
                    case EuroExchangeRate euro when (euro.ExchangeRateValue > 3):
                        Console.WriteLine("Melhor ficar em casa!");
                        break;
                }
            }
            
        }
    }

    public abstract class ExchangeRate
    {
        public DateTime DateExchangeRate { get; set; }
        public abstract string currencyAbbreviation { get; }
        public abstract string currencyName { get; }
    }

    public class DollarExchangeRate : ExchangeRate
    {
        public override string currencyAbbreviation
        { get { return "USD"; } }

        public override string currencyName
        { get { return "Dollar"; } }

        public double CommercialValue { get; set; }
        public double TurismValue { get; set; }
    }

    public class EuroExchangeRate : ExchangeRate
    {
        public override string currencyAbbreviation
        { get { return "Euro"; } }

        public override string currencyName
        { get { return "EUR"; } }

        public double ExchangeRateValue { get; set; }
    }


