using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            SumEvens();
        }

        public static void Even()
        {
            int A;
            Console.WriteLine("PARITY CHECK");
            Console.WriteLine("Please enter the number:");
            A = Int16.Parse(Console.ReadLine());
            if (A%2 == 0)
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");
            }
        }
 
        public static void Numbers()
        {
            int sum = 0,count = 0;
            double a = 0;
            string _numbers = "";
            Console.WriteLine("Please enter the number a < 100:");
            try
            {
                a = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error.");
                Numbers();
            }
            _numbers = a.ToString().Replace(",","");
            for (int i = 0; i < _numbers.Length; i++)
            {
                sum += Int32.Parse(_numbers[i].ToString());
                count++;
            }
            Console.WriteLine("Sum: {0}  Number of digits: {1}", sum, count);
        }

        public static void InchConvert()
        {
            double result = 0;
            int operation = 0;
            do
            {
                Console.WriteLine("Inch Converter.");
                Console.WriteLine("1. Inch -> Centimeter.\n2. Centimeter -> Inch.\n3. Exit.");
                operation = Int32.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Please enter number of inches:");
                        result = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("{0} inches = {1} centimeters", result, result * 2.54);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter number of centimeters:");
                        result = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("{0} centimeters = {1} inches", result, (result/2.54).ToString("#.##"));
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while (operation != 3);
            
        }
        public static void MakeLine()
        {
            string symbol = "";
            int _length = 0, direction = 0;
            Console.WriteLine("Draw line.");
            Console.WriteLine("Please enter the length of line:");
            _length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the symbol of line:");
            symbol = Console.ReadLine();
            Console.WriteLine("Please enter the direction of line (0 = horisontal, 1 = vertical):");
            direction = Int32.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < _length; i++)
            {
                if (direction == 0)
                {
                    Console.WriteLine(symbol);
                }
                else
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }

        public static void SumEvens()
        {
            int A = 0, B = 0, result = 0, i = 0;
            Console.WriteLine("Sum evens.");
            Console.WriteLine("Please enter the first number of range:");
            A = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the last number of range:");
            B = Int16.Parse(Console.ReadLine());
            i = A;
            while (i != B)
            {
                if (i%2 != 0)
                {
                    result += i;
                }
                i++;
            }
            Console.Clear();
            Console.WriteLine("The sum of evens in range from {0} to {1} = {2}", A, B, result);
        }
    }
}
