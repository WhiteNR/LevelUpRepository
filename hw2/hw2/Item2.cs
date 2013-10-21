using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Item2
    {
        public static void Start()
        {
            double P, amount = 1000,profit = 0;
            int month = 0;
            Console.WriteLine("P>0");
            Console.WriteLine("Please enter P:");
            try
            {
                P = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                while (amount < 1100)
                {
                    month++;
                    profit = Math.Round(amount * P,2);
                    amount += profit;
                    Console.WriteLine("{0} {1} {2}", month, profit.ToString("0.00"), amount.ToString("0.00"));
                }
                Console.WriteLine("\nAmount: {0} Month: {1}", amount.ToString("0.00"), month);
            }
            catch 
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();
        }
    }
}
