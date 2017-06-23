using System;

namespace OthersExamples_.net4._6._2
{
    public static class BinHex
    {
        public static int YBin {get;set;}
        public static int ZBin { get; set; }

        public static int YHex { get; set; }

        public static int YInt { get; set; }
        public static double ZDouble { get; set; }
       
        public static void SumBin()
        {
            Console.WriteLine($"Y = {YBin}");
            Console.WriteLine($"Z = {ZBin}");
            Console.WriteLine($"Y + Z = {YBin + ZBin}"); 
        }

        public static void PrintAll()
        {
            Console.WriteLine($"YBin = {YBin}");
            Console.WriteLine($"ZBin = {ZBin}");
            Console.WriteLine($"\nYHex = {YHex}");
            Console.WriteLine($"ZHex = {ZDouble}");
            Console.WriteLine($"\nYInt = {YInt}");
            Console.WriteLine($"ZDouble = {ZDouble}");

        }

        
    }
}
