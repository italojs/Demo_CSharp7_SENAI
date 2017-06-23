using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthersExamples_.net4._6._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //-------Pattern Matching------------
            DollarExchangeRate dollar = new DollarExchangeRate()
            {
                DateExchangeRate = new DateTime(2017, 3, 24),
                CommercialValue = 3.1083,
                TurismValue = 3.2700
            };
            PatternMatching.Example(dollar);

            EuroExchangeRate euro = new EuroExchangeRate()
            {
                DateExchangeRate = new DateTime(2017, 3, 24),
                ExchangeRateValue = 3.3695
            };
            PatternMatching.Example(euro);
            //-------------------------------------------



            //--------Exception Temperature--------
            ExceptionTemperature.Celsius = -30000;
            //------------------------------------


            //-------------OutVariables-------------
            OutVariables.Example1("07/03/2017");
            OutVariables.Example1("GenerateSomeError");
            OutVariables.Example2("07/03/2017");
            //------------------------------------------


            //------------Local Functions-------------
            string Inverse(string value)
            {
                return new string(
                    value.ToCharArray().Reverse().ToArray());
            }
            Console.WriteLine(Inverse("italo"));

            string Inverse2(string value) => new string(value.ToCharArray().Reverse().ToArray());

            Console.WriteLine(Inverse2("italo"));
            //------------------------------


            //-----------Binary Digits---------

            BinHex.YBin = 0b01011001; // 89
            BinHex.ZBin = 0B01011010; // 90
            BinHex.SumBin();//179

            //--------------------------

            //-----------Expression Bodied Members------------
            ExpressionBodiedMembers example = new ExpressionBodiedMembers(@"C:\Temp\Some\Path");
            //-------------------------------------------------

            //---------------Digit Separator---------------
            BinHex.YBin = 0b01_01_10_01; // 01011001 (binário) = 89 (decimal)
            BinHex.ZBin = 0b01_01_10_01; // 01011001 (binário) = 89 (decimal)
            BinHex.SumBin();

            BinHex.YHex = 0X5_A; // 5A (hexadecimal) = 80 (decimal)

            BinHex.YInt = 204_500_000;
            BinHex.ZDouble = 11_208.08;

            BinHex.PrintAll();
            //----------------------------------------------------

            //------------ref return---------------------
            var someNumber = 3;
            RefReturn.IncrementValue(ref someNumber);
            Console.WriteLine(someNumber);

            ref int someNumberReference = ref RefReturn.GetReference();
            Console.WriteLine(someNumberReference);

            RefReturn.IncrementReference();
            Console.WriteLine(someNumberReference);

            Console.ReadKey();
        }
    }
}
