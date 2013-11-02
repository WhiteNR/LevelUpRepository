using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, n = 0;
            x = Convert.ToInt32(Console.ReadLine());
             n = Convert.ToInt32(Console.ReadLine());
            string str = ConverterOfNumericSystem(x, n);
            Console.WriteLine(str);
        }

        public static string ConverterOfNumericSystem(int number, int numericSystem)
        {
            string str = "";

            while (number % numericSystem < numericSystem)
            {
                str += (string)Convert.ToString(number / numericSystem);
            }
            return  str;
        }
    }
}
