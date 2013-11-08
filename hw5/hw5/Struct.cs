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

        public Struct(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Struct Parse(string str)
        { 
            string[] strArr;
            char[] separator = {' ',','};
            strArr = str.Split(separator,2);
            if (strArr.Length == 2)
            {
                return new Struct(Int32.Parse(strArr[0]), Int32.Parse(strArr[1]));
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
