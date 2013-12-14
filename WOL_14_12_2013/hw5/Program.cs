using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries.Ukraine;
using Countries.USA;
using Countries.Russia;
using hw5.Countries;
using Menu;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menuItems = new List<string>();

            Dictionary<int, MenuItem> MyDict = new Dictionary<int, MenuItem>();

            MyDict.Add(1, new MenuItem("Line Eq.", new CommonDel(LineMethod)));
            MyDict.Add(2, new MenuItem("Compare Cities.", new CommonDel(CityCompare)));
            MyDict.Add(3, new MenuItem("Fraction.", new CommonDel(Fraction)));
            MyDict.Add(4, new MenuItem("Complex.", new CommonDel(Complex)));
            MyDict.Add(5, new MenuItem("Sort Cities.", new CommonDel(SortCities)));

            MenuCls menuCls = new MenuCls("My Menu", MyDict);
            menuCls.ShowMenu();
        }

        private static void CityCompare()
        {
            Console.WriteLine("Countries:");
            Kyiv kyiv = new Kyiv();
            Washington washington = new Washington();
            Moskow moskow = new Moskow();
            if ((kyiv.CompareTo(washington) > 0) && (kyiv.CompareTo(moskow) > 0))
                Console.WriteLine("Kyiv is bigger");
            else if ((washington.CompareTo(kyiv) > 0) && (washington.CompareTo(moskow) > 0))
                Console.WriteLine("Washington is bigger");
            else
                Console.WriteLine("Moskow is bigger");
            Console.ReadLine();
        }

        private static void Fraction()
        {
            Console.WriteLine("Farction:");
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;

            Console.WriteLine("f = {0}", f.ToString());
            Console.WriteLine("f1 = {0}", f1.ToString());
            Console.WriteLine("f2 = {0}", f2.ToString());
            Console.WriteLine("f3 = {0}", f3.ToString());
            Console.ReadLine();
        }

        private static void Complex()
        {
            Console.WriteLine("Complex:");
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 ={0}", z1);
            Console.ReadLine();
        }

        private static void SortCities()
        {
            Console.WriteLine("Countries:");

            List<City> cityList = new List<City>();
            cityList.Add(new Kyiv());
            cityList.Add(new Washington());
            cityList.Add(new Moskow());
            cityList.Sort();

            foreach (City item in cityList)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void LineMethod()
        {
            string str1, str2;
            Console.WriteLine("Line:");
            Console.WriteLine("Please Enter A1,B1:");
            str1 = Console.ReadLine();
            Console.WriteLine("Please Enter A2 B2:");
            str2 = Console.ReadLine();

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
        }
    }
}
