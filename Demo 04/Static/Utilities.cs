using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Static
{
    // static (helper)
    internal static class Utilities
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        private static double pi; // static => inside a static property

        static Utilities()
        {
            pi = 3.14;
        }


        public static double CmToInch (double cm)
        {
            return cm / 2.54;
        }

        public static double PI { get { return pi; } }
    }
}
