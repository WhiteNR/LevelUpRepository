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
            string str1, str2;

            //3
            Console.WriteLine("Line:");
            Console.WriteLine("Please Enter A1,B1:");
            str1 = Console.ReadLine();
            Console.WriteLine("Please Enter A2 B2:");
            str2 = Console.ReadLine();
            //Console.WriteLine(coefforline.lineequation(3, -2, 1, 3, 4, 5));

            try
            {
                Struct struct1 = Struct.Parse(str1);
                Struct struct2 = Struct.Parse(str2);
                Console.WriteLine(LineEq.CountLineEq(struct1, struct2, 4, 5));
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
            //4
            Console.WriteLine("Countries:");
            Kyiv kyiv = new Kyiv();
            Washington washington = new Washington();
            Moskow moskow = new Moskow();
            if ((kyiv.Population > washington.Population) && (kyiv.Population > moskow.Population))
                Console.WriteLine("Kyiv is bigger");
            else if ((washington.Population > kyiv.Population) && (washington.Population > moskow.Population))
                Console.WriteLine("Washington is bigger");
            else
                Console.WriteLine("Moskow is bigger");
            Console.ReadLine();
            
            //6
            Console.WriteLine("Complex:");
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 ={0}", z1);
            Console.ReadLine();

            //7
            Console.WriteLine("Farction:");
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;

            Console.WriteLine("f = {0}",f.ToString());
            Console.WriteLine("f1 = {0}", f1.ToString());
            Console.WriteLine("f2 = {0}", f2.ToString());
            Console.WriteLine("f3 = {0}", f3.ToString());
            Console.ReadLine();

        }
    }
}
