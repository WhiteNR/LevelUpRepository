using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
             //Item1.Start();
             //Item2.Start();
             //Item3.Start();
             //Item4.Start();

            string a = "";
            do
            {
                Console.Write("Menu:\r\n1. Clear screen\r\n2. Say Hello!\r\n3. Exit\r\n\r\nPlease enter: ");

                a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Hello");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (a != "3");
        }
    }
}
