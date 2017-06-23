using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthersExamples_.net4._6._2
{
    public static class OutVariables
    {

        public static void Example1(string birthday)
        {


            //DateTime outBirthday;
            //if (DateTime.TryParse(birthday, out outBirthday))
            //if (DateTime.TryParse(birthday, out DateTime outBirthday))
            if (DateTime.TryParse(birthday, out var outBirthday))
            {
                DateTime dataAtual = DateTime.Now.Date;
                Console.WriteLine($"Today: { dataAtual: dd/MM/yyyy}");
                Console.WriteLine($"BirthDay: { outBirthday: dd/MM/yyyy}");
                TimeSpan interval = dataAtual.Subtract(outBirthday);
                Console.WriteLine($"Days in yout life: { interval.TotalDays}");
            }
            else
            {
                Console.WriteLine($"Invalid Date: {birthday}");
            }

            Console.Write(Environment.NewLine);
        }

        public static void Example2(string birthday)
        {

            if (DateTime.TryParse(birthday, out _))
            {
                DateTime dataAtual = DateTime.Now.Date;
                Console.WriteLine($"it's ok");
                
            }
            else
            {
                Console.WriteLine($"Invalid Date: {birthday}");
            }

            Console.Write(Environment.NewLine);
        }

 
    }
}
