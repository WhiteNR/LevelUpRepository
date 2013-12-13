using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1.Classes
{
    public class Student
    {
        private Person _person;
        private Person.Education _education;
        private int _groupNumber;
        private List<Person.Exam> _exams;

        public Student()
        {
            _person = new Person();
            _education = Person.Education.Вachelor;
            _groupNumber = 0;
            _exams = new List<Person.Exam>();
        }

        public Student(Person person, Person.Education education,int groupNumber)
        {
            _person = person;
            _education = education;
            _groupNumber = groupNumber;
            _exams = new List<Person.Exam>();
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

        public object DeepCopy()
        {
            Student student = new Student();
            student._person = (Person)this._person.DeepCopy();
            student._education = this._education;
            foreach (Person.Exam item in _exams)
            {
                student._exams.Add((Person.Exam)item.DeepCopy());
            }
            student._groupNumber = this._groupNumber;
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

        public override string ToString()
        {
            string ret = _person.ToString() + "\r\n" + "Education Type: " + _education.ToString() + "\r\n" + "GroupNumber: " + _groupNumber.ToString() + "\r\n" + "Exams:\r\n";

            foreach (Person.Exam item in _exams)
            {
                ret += item.ToString() + "\r\n";
            }
            return ret;
        }

        public virtual string ToShortString()
        {
            return _person.ToShortString() + "\r\n" + "Education Type: " + _education.ToString() + "\r\n" + "GroupNumber: " + _groupNumber.ToString() + "\r\n" + "Avarage Mark: " + AvgMark.ToString();
        }

        public Person Person                { get { return _person; }       set { _person = value; } }
        public Person.Education Education   { get { return _education; }    set { _education = value; } }
        public int GroupNumber              { get { return _groupNumber; }  set { _groupNumber = value; } }
        public List<Person.Exam> Exams      { get { return _exams; }        set { _exams = value; } }

    }
}
/*


*/