using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers();
        }

        public static void Even()
        {
            int A;
            Console.WriteLine("PARITY CHECK");
            Console.WriteLine("Please enter the number:");
            A = Int16.Parse(Console.ReadLine());
            if (A%2 == 0)
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
        }
 
        public static void Numbers()
        {
            int sum = 0,count = 0;
            double a = 0;
            string _numbers = "";
            Console.WriteLine("Please enter the number a < 100:");
            try
            {
                a = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error.");
                Numbers();
            }
            _numbers = a.ToString().Replace(",","");
            for (int i = 0; i < _numbers.Length; i++)
            {
                sum += Int32.Parse(_numbers[i].ToString());
                count++;
            }
            Console.WriteLine("Sum: {0}  Number of digits: {1}", sum, count);
        }

    }
}
