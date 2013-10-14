using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Item1
    {
        public static void Start()
        {
            int A, B, C, x, y, number, area;
            Console.WriteLine("A, B, C");
            Console.WriteLine("Please enter A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter C:");
            C = Convert.ToInt32(Console.ReadLine());

            x = A / C;
            y = B / C;

            if (x > 0 && y > 0)
            {
                number = x * y;
                area = (A * B) - number * C * C;

                Console.WriteLine("\nNumber of squares: {0}", number);
                Console.WriteLine("\nQuantity of free space: {0}", area);   
            }
            else
            {
                Console.WriteLine("Error! Not enough space for squares.");
            }
            Console.ReadLine();
        }
    }
}
