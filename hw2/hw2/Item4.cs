using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Item4
    {
        public static void Start()
        {
            int N, B = 0;
            Console.WriteLine("N>0");
            Console.WriteLine("Please enter N:");
            try
            {
                N = Convert.ToInt32(Console.ReadLine());
                while(N > 0)
                {
                    B = B * 10;
                    B += (N % 10);
                    N = N / 10;
                }
                Console.WriteLine(B);
            }
            catch 
            {
                Console.WriteLine("Error!");
            }
            Console.ReadLine();
        }
    }
}
