using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "A", "AS", "e", "R", "3", "67", "W", "a", "1", "34", "76" };

            var result = from a in arr where a.StartsWith("A") select a;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
