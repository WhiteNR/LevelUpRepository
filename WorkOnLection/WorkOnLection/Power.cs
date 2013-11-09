using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOnLection
{
    class Power
    {
        public static double DevPower(int a, int b)
        {
            return Math.Pow(a / b, 2);
        }

        public static double SumPower(double a, double b)
        {
            return Math.Pow(a + b, 2);
        }
    }
}
