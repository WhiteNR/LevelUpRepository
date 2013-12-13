using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p2;

namespace p2.Classes
{
    public class Person : IDateAndCopy
    {
        public enum Education
        {
            Specialist, Вachelor, SecondEducation
        }

        protected string _firstName;
        protected string _lastName;
        protected DateTime _dob;

        public Person()
        {
            _firstName = "";
            _lastName = "";
            _dob = new DateTime(1901, 1, 1);
            IsDOBChangeble = 1;
            Date = DateTime.Today;
        }

        public Person(string firstName, string lastName, DateTime dob)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dob = dob;
            IsDOBChangeble = 1;
            Date = DateTime.Today;
        }

        public virtual object DeepCopy()
        {
            Person person = new Person();
            person._dob = this._dob;
            person._firstName = this._firstName;
            person._lastName = this._lastName;
            person.IsDOBChangeble = this.IsDOBChangeble;
            return person;
        }

        public string FirstName
        {
            get
            { return _firstName; }
            set
            { _firstName = value; }
        }

        public string LastName
        {
            get
            { return _lastName; }
            set
            { _lastName = value; }
        }

        public DateTime DOB
        {
            get
            { return _dob; }
            set
            {
                if (IsDOBChangeble == 1)
                {
                    _dob = value;
                }
                else
                {
                    throw new AccessViolationException("Access denied.");
                }
            }
        }

        public int IsDOBChangeble
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Person p1 = obj as Person;
            if (p1 == null) return false;
            return (p1._dob == _dob && p1._firstName == _firstName && p1._lastName == _lastName);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if ((object)p1 == null) return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return (!(p1 == p2));
        }

        public override int GetHashCode()
        {
            return this._firstName.GetHashCode() ^ this._lastName.GetHashCode() ^ this._dob.GetHashCode();
        }

        public override string ToString()
        {
            return "First name: " + _firstName + "\r\nLast name: " + _lastName + "\r\nDOB: " + _dob;
        }

        public virtual string ToShortString()
        {
            return "First name: " + _firstName + "\r\nLast name: " + _lastName;
        }

        public class Exam : IDateAndCopy
        {
            public Exam()
            {
                ExamName = "";
                ExamMark = 0;
                ExamDateTime = new DateTime(1901, 1, 1);
            }

            public Exam(string examName, int examMark, DateTime examDateTime)
            {
                ExamName = examName;
                ExamMark = examMark;
                ExamDateTime = examDateTime;
            }

            public object DeepCopy()
            {
                Exam exam = new Exam();
                exam.ExamDateTime = this.ExamDateTime;
                exam.ExamMark = this.ExamMark;
                exam.ExamName = this.ExamName;
                return exam;
            }

            public string ExamName { get; set; }
            public int ExamMark { get; set; }
            public DateTime ExamDateTime { get; set; }

            public override string ToString()
            {
                return "Exam: " + ExamName + " Mark: " + ExamMark.ToString() + " Date: " + ExamDateTime.ToShortDateString();
            }


            public DateTime Date
            {
                get;
                set;
            }
        }

        public virtual DateTime Date
        {
            get;
            set;
        }
    }
}
