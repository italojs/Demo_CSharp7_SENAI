using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSENAI_CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //use nuguet System.Value.Tuple to framework >= 4.6.2
            Console.WriteLine("-------------Example 1--------------\n");
            Tuple.Exemple1();
            Console.WriteLine("\n-------------Example 2 ------------\n");
            Tuple.Example2();

            Console.ReadKey();

        }
    }
}
