using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.AbstaractClasses
{
    public abstract class Product
    {
        public Product(string name, int number, Decimal price)
        {
            Name = name;
            Number = number;
            Price = price;
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public Decimal Price { get; protected set; }
    }
}
