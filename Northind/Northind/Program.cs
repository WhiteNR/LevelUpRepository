using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northind
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer = new Customers();
            Territories territories = new Territories();

            foreach (var item in customer.GetCustomersCountries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in customer.GetCustomersInCountry("Germany"))
            {
                Console.WriteLine(item.ContactName);
            }

            Console.WriteLine();

            foreach (var item in customer.GetCustomersInCountry("Germany"))
            {
                Console.WriteLine(item.ContactName);
            }

            Console.WriteLine();

            //foreach (var i in customer.GetCustomersInCountryGroup)
            //{ 
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //}
        }
    }
}
