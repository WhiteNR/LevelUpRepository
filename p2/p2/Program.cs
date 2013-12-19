using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2.Classes;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Keith", "Ebner", DateTime.Parse("1978-05-11"));
            Person person2 = new Person("Keith", "Ebner", DateTime.Parse("1978-05-11"));

            if (object.ReferenceEquals(person1, person2))
            {
                Console.WriteLine("Reference Equals");
            }
            else
            {
                Console.WriteLine("Reference is not Equals");
            }

            if (person1 == person2)
            {
                Console.WriteLine("Objects are equal");
                Console.WriteLine("Person1 hash code: " + person1.GetHashCode());
                Console.WriteLine("Person2 hash code: " + person2.GetHashCode());
            }
            else
            {
                Console.WriteLine("Objects are not equals");
            }

            Console.WriteLine();

            Student student = new Student(new Person("Keith", "Ebner", DateTime.Parse("1978-05-11")), Person.Education.Specialist, 4);
            student.AddExams(new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("History", 5, DateTime.Parse("2013-11-12")));
            student.AddTests(new Test("History", true), new Test("MySubj", false));

            Console.WriteLine(student.ToString());

            Console.WriteLine(student.Person.ToString());

            Student student1 = (Student)student.DeepCopy();

            student.FirstName = "asdafasd";

            Console.WriteLine();

            Console.WriteLine(student.ToString());

            Console.WriteLine();

            Console.WriteLine(student1.ToString());

            Console.WriteLine();

            try
            {
                student.GroupNumber = 1;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            StudentEnumerator studentEnumerator = new StudentEnumerator(student);

            foreach (var item in studentEnumerator)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in student.Iterator(3))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in student.IteratorPassedTests())
            {
                Console.WriteLine(item);
            }
        }
    }
}

