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
            int N;
            Console.WriteLine("N>0");
            Console.WriteLine("Please enter N:");
            try
            {
                N = Convert.ToInt32(Console.ReadLine());
                for (int i = N.ToString().Length - 1; i >= 0; i--)
                {
                    Console.Write(N.ToString()[i]);
                }
            }
            catch 
            {
                Console.WriteLine("Error. N > 0.");
            }
            Console.ReadLine();
        }
    }
}
