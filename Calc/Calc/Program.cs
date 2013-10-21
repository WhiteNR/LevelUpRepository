using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Calculator Calc = new Calculator();
            //Calc.Calculating();

            int x, y;
            Console.WriteLine("Enter 1 value:");
            x = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter 2 value:");
            if ((y = Convert.ToInt16(Console.ReadLine())) < x)
            {
                x = y;
            }

            Console.WriteLine("Enter 3 value:");
            if ((y = Convert.ToInt16(Console.ReadLine())) < x) 
            {
                x = y;
            }
            Console.WriteLine("Min value: ");
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
