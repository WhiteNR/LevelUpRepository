using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2.Classes
{
    public class StudentEnumerator : IEnumerable
    {
        private ArrayList _array = new ArrayList();

        public StudentEnumerator(Student student)
        {
            ArrayList exams = student.Exams;
            ArrayList tests = student.Tests;

            foreach (Person.Exam item in exams)
            {
                _array.Add(item.ExamName);
            }

            foreach (Test item in tests)
            {
                _array.Add(item.SubjectName);
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _array)
            {
                yield return item;
            }
        }
    }
}
