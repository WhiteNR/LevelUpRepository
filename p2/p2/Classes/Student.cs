using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2;

namespace p2.Classes
{
    public class Student : Person, IDateAndCopy
    {
        private Person.Education _education;
        private int _groupNumber;
        private ArrayList _exams;
        private ArrayList _tests;


        public Student()
            : base()
        {
            _education = Person.Education.Вachelor;
            _groupNumber = 0;
            _exams = new ArrayList();
            _tests = new ArrayList();
        }

        public Student(Person person, Person.Education education, int groupNumber)
            : base(person.FirstName, person.LastName, person.DOB)
        {
            _education = education;
            _groupNumber = groupNumber;
            _exams = new ArrayList();
            _tests = new ArrayList();
        }

        public override object DeepCopy()
        {
            Student student = new Student((Person)this, this._education, this._groupNumber);
            foreach (var item in _exams)
            {
                student._exams.Add(((Person.Exam)item).DeepCopy());
            }

            foreach (var item in _tests)
            {
                student._tests.Add(((Test)item).DeepCopy());
            }
            return student;
        }

        public bool this[Person.Education education]
        {
            get
            {
                return education == _education;
            }
        }

        public void AddExams(params Person.Exam[] exams)
        {
            Exams.AddRange(exams);
        }

        public void AddTests(params Test[] tests)
        {
            _tests.AddRange(tests);
        }

        public new string ToString()
        {
            string ret = base.ToString() + "\r\n" + "Education Type: " + _education.ToString() + "\r\n" + "GroupNumber: " + _groupNumber.ToString() + "\r\n" + "Exams:\r\n";

            foreach (Person.Exam item in _exams)
            {
                ret += item.ToString() + "\r\n";
            }
            ret += "Tests:\r\n";
            foreach (Test item in _tests)
            {
                ret += item.ToString() + "\r\n";
            }
            return ret;
        }

        public override string ToShortString()
        {
            return base.ToShortString() + "\r\n" + "Education Type: " + _education.ToString() + "\r\n" + "GroupNumber: " + _groupNumber.ToString() + "\r\n" + "Avarage Mark: " + AvgMark.ToString();
        }

        public double AvgMark
        {
            get
            {
                double sum = 0;
                int count = 0;
                if (_exams != null)
                {
                    foreach (Person.Exam item in _exams)
                    {
                        sum += item.ExamMark;
                        count++;
                    }
                }
                if (count > 0) return sum / count;
                else return 0;
            }
        }

        public Person Person
        {
            get
            {
                return this;
            }
            set 
            { 
                 base._firstName = Person.FirstName;
                 base._lastName = Person.LastName;
                 base._dob = Person.DOB;
                 base.IsDOBChangeble = Person.IsDOBChangeble;
                 base.Date = Person.Date;
            }
        }

        public Person.Education StudentEducation { get { return _education; } set { _education = value; } }
        public ArrayList Exams { get { return _exams; } set { _exams = value; } }
        public ArrayList Tests { get { return _tests; } set { _tests = value; } }
        public int GroupNumber 
        {
            get 
            { 
                return _groupNumber; 
            }
            set
            {
                if (value <= 100 || value > 599)
                {
                    throw new FormatException("Wrong group number! The number should be between 100 and 599.");
                }
                else
                {
                    _groupNumber = value;
                }
            }
        }
        public override DateTime Date
        {
            get;
            set;
        }

        public IEnumerable Iterator(int mark)
        {
            foreach (Exam item in _exams)
            {
                if (item.ExamMark > mark)
                {
                    yield return item.ExamName;
                }
            }
        }

        public IEnumerable IteratorPassed()
        {
            foreach (Exam item in _exams)
            {
                if (item.ExamMark > 2)
                {
                    yield return item.ExamName;
                }
            }

            foreach (Test item in _tests)
            {
                if (item.IsPassed == true)
                {
                    yield return item.SubjectName;
                }
            }
        }

        public IEnumerable IteratorPassedTests()
        {
            foreach (Test itemTest in _tests)
            {
                foreach (string itemExam in Iterator(2))
                {
                    if (itemTest.SubjectName == itemExam)
                    {
                        yield return itemTest.SubjectName;
                    }
                }
               
            }
        }
    }
}


