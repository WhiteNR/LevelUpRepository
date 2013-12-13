using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2.Classes
{
    public class Test : IDateAndCopy
    {
        public Test()
        {
            SubjectName = "";
            IsPassed = false;
        }

        public Test(string name, bool pass)
        {
            SubjectName = name;
            IsPassed = pass;
        }

        public override string ToString()
        {
            return "Subject Name: " + SubjectName + "\r\nPassed: " + IsPassed;
        }

        public string SubjectName { get; set; }
        public bool IsPassed { get; set; }

        public object DeepCopy()
        {
            Test test = new Test(this.SubjectName, this.IsPassed);
            test.Date = this.Date;
            return test;
        }

        public DateTime Date
        {
            get;
            set;
        }
    }
}
