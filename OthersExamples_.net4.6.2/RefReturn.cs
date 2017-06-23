using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OthersExamples_.net4._6._2
{
    public static class RefReturn
    {
        private static int someValue = 555;
        public static void IncrementValue(ref int number)
        {
            number++;
        }

        public static ref int GetReference()
        {
            //return ref 555; dont work
            return ref someValue;
        }

        public static void IncrementReference()
        {
            someValue++;
        }
    }
}
