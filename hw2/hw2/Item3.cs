﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Item3
    {
        public static void Start()
        {
            int A, B;
            Console.WriteLine("A < B");
            Console.WriteLine("Enter A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter B:");
            B = Convert.ToInt32(Console.ReadLine());
            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Error. A >= B.");
            }
            Console.ReadLine();
        }
    }
}
