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
            /*Student student = new Student(new Person("Keith", "Ebner", DateTime.Parse("1978-05-11")), Person.Education.Specialist, 4);
            student.AddExams(new Person.Exam("Math", 4, DateTime.Parse("2013-12-12")), new Person.Exam("History", 5, DateTime.Parse("2013-11-12")));
            foreach (var item in student)
            {
                Console.WriteLine(((Person.Exam)item).ExamName);
            }

            foreach (Person.Exam item in student.Iterator(4))
            {
                Console.WriteLine(((Person.Exam)item).ExamName);
            }
            */
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
        }
    }
}
/*

В методе Main()
1.  Создать два объекта типа  Person  с совпадающими данными и проверить,  что ссылки на объекты не равны, а объекты равны, вывести значения хэш-кодов для объектов.
2.  Создать  объект  типа  Student,  добавить  элементы  в  список  экзаменов  и зачетов, вывести данные объекта Student. 
3.  Вывести значение свойства типа Person для объекта типа Student.
4.  С  помощью  метода  DeepCopy()  создать  полную  копию  объекта  Student. 
Изменить  данные  в  исходном  объекте  Student  и  вывести  копию  и 
исходный объект, полная копия исходного объекта должна остаться без изменений. 
5.  В  блоке  try/catch  присвоить  свойству  с  номером  группы  некорректное 
значение,  в  обработчике  исключения  вывести  сообщение,  переданное 
через объект-исключение. 
6.  С  помощью  оператора  foreach  для  итератора,  определенного  в  классе 
Student, вывести список всех зачетов и экзаменов. 
7.  С  помощью  оператора  foreach  для  итератора  с  параметром, 
определенного  в  классе  Student,  вывести  список  всех  экзаменов  с оценкой выше 3. 
*/
