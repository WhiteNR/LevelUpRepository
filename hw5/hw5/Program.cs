using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries.Ukraine;
using Countries.USA;
using Countries.Russia;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Struct strct = new Struct();

            Kyiv kyiv = new Kyiv();
            Washington washington = new Washington();
            Moskow moskow = new Moskow();

            if ((kyiv.Population > washington.Population) && (kyiv.Population > moskow.Population))
                Console.WriteLine("Kyiv is bigger");
            else if ((washington.Population > kyiv.Population) && (washington.Population > moskow.Population))
                Console.WriteLine("Washington is bigger");
            else
                Console.WriteLine("Moskow is bigger");

            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 ={0}", z1);


        }
    }
}
