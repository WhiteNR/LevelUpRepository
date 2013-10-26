using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Figures
    {
        public static void ShowFigures()
        {
            Console.Clear();
            int A, A1;
            string C = "*";

            Console.WriteLine("Please enter the size of figures:");
            A = Int16.Parse(Console.ReadLine());
            A1 = A * 2;

            //Square
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    Console.Write(C);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Hollow square
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    if (i == 0 || j == 0 || i == A - 1 || j == A - 1)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Hollow triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    if (j == i || j == 0 || i == A - 1)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    if (j <= A - 1 - i)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Hollow triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A; j++)
                {
                    if (j == A - 1 - i || i == 0 || j == 0)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if ((int)A1 / 2 + i - 1 >= j && (int)A1 / 2 - i - 1 <= j)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Hollow triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if ((int)A1 / 2 + i - 1 == j || (int)A1 / 2 - i - 1 == j || i == A - 1)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if (A1 - 2 - i >= j && i <= j )
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Hollow triangle
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if (A1 - 2 - i == j ||  i == j || i == 0)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Rhombus
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if (A1 / 2 + i - 1 >= j && A1 / 2 - i - 1 <= j)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if (A1 - 2 - i >= j && i <= j)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //Hollow rhombus
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if (A1 / 2 + i - 1 == j || A1 / 2 - i - 1 == j)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i < A; i++)
            {
                for (int j = 0; j < A1 - 1; j++)
                {
                    if (A1 - 2 - i == j || i == j)
                    {
                        Console.Write(C);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

