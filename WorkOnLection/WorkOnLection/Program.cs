using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOnLection
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("ololo", "ololoev","ololoevich");
            student.AddAdministratingMark(5);
            student.AddAdministratingMark(4);
            Console.WriteLine(student.GetTotalStudentInfo());
            Console.ReadLine();
            //int[][] mas = new int[4][];
            //mas[0] = new int[8];
            //mas[1] = new int[4];
            //mas[2] = new int[2];
            //mas[3] = new int[1];

            //int count = 0, sum = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    for (int j = 0; j < mas[i].Length; j++)
            //    {
            //        mas[i][j] = count + 1;
            //        Console.Write(mas[i][j]);
            //        Console.Write(" ");
            //        sum += mas[i][j];
            //        count++;
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Number of elements = {0} Sum of elements = {1} Average = {2}", count, sum, sum / count);
            //Console.ReadLine();


            //int a = 10, b = 5;
            //short r;
            //Swap(ref a, ref b);
            //Console.WriteLine("a = {0} b = {1}",a,b);
            //bool t = Int16.TryParse("16", out r);
        }

        //static void Swap(ref int a, ref int b)
        //{
        //    int tmp = a;
        //    a = b;
        //    b = tmp;
        //}
    }
}
