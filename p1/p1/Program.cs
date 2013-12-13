using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1.Classes;
using System.Diagnostics;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(new Person("Keith", "Ebner", DateTime.Parse("1978-05-11")), Person.Education.Specialist, 4);
            Console.WriteLine(student.ToShortString());
            Console.WriteLine();
            Console.WriteLine("SecondEducation" + student[Person.Education.SecondEducation]);
            Console.WriteLine("Specialist" + student[Person.Education.Specialist]);
            Console.WriteLine("Вachelor" + student[Person.Education.Вachelor]);
            Console.WriteLine();
            Console.WriteLine(student.ToString());
            student.AddExams(new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("History", 5, DateTime.Parse("2013-11-12")));
            Console.WriteLine();
            Console.WriteLine(student.ToString());

            Student student1 = (Student)student.DeepCopy();
            student1.Person.DOB = DateTime.Parse("1985-05-11");

            Console.WriteLine();
            Console.WriteLine(student.ToString());

            Console.WriteLine();
            Console.WriteLine(student1.ToString());

            Console.ReadLine();

            Test();
        }

        public static void Test()
        {
            Person.Exam[] exam1 = new Person.Exam[10];
            Person.Exam[,] exam2 = new Person.Exam[5,2];
            Person.Exam[][] exam3 = new Person.Exam[3][];

            for (int i = 0; i < 10; i++)
            {
                exam1[i] = new Person.Exam("Math", 4, DateTime.Parse("2013-12-12"));
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    exam2[i,j] = new Person.Exam("Math", 4, DateTime.Parse("2013-12-12"));
                }
            }

            exam3[0] = new Person.Exam[2] { new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")) };
            exam3[1] = new Person.Exam[3] { new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")) };
            exam3[2] = new Person.Exam[5] { new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")) };

            Person.Exam testExam;
            Stopwatch sWatch = new Stopwatch();

            sWatch.Start();
            foreach (Person.Exam item in exam1)
            {
                testExam = (Person.Exam)item.DeepCopy();
            }
            sWatch.Stop();
            Console.WriteLine(sWatch.Elapsed.ToString());
            Console.WriteLine();
            sWatch.Reset();

            sWatch.Start();
            foreach (Person.Exam item in exam2)
            {
                testExam = (Person.Exam)item.DeepCopy();
            }
            sWatch.Stop();

            Console.WriteLine(sWatch.Elapsed.ToString());
            Console.WriteLine();
            sWatch.Reset();

            sWatch.Start();
            foreach (Person.Exam[] itemList in exam3)
            {
                foreach (Person.Exam item in itemList)
                {
                    testExam = (Person.Exam)item.DeepCopy();
                }
            }
            sWatch.Stop();
            Console.WriteLine(sWatch.Elapsed.ToString());
            Console.WriteLine();
        }

    }
}
