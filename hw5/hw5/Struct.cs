using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    struct Struct
    {
        int a, b;

        public void Parse(string str)
        { 
            string[] strArr;
            char[] separator = {' ',','};
            strArr = str.Split(separator,2);
            if (strArr.Length == 2)
            {
                a = Int32.Parse(strArr[0]);
                b = Int32.Parse(strArr[1]);
            }
            else
            {
                throw (new FormatException());
            }
        }

        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
    }
}
