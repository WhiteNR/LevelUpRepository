using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOL_21_12_13
{

    public class MyAttridbte : Attribute
    {
        public int MyProperty { get; set; }
    }

    class Program
    {
        delegate void TestDelegate(string a);

        static void Main(string[] args)
        {
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(mycls));

            TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            myDel("Hello");

        }
    }

    [MyAttridbte(MyProperty = 1)]
    public class mycls
    { 
    
    }
}
