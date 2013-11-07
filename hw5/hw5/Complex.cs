using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Complex
    {
        int deg;
        double a,b;
        public Complex() 
        {
            deg = 1;
        }
        public Complex(double a, double b) : this()
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            if (this.a == 0 && this.b == 0)
            {
                return String.Format("0");
            }
            else
            {
                return String.Format("{0} + {1} * i", this.a, this.b);
            }
        }

        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(x.a * y.b, x.b * y.b);
        }

        public static Complex operator *(double x, Complex y)
        {
            return new Complex(x * y.b, x * y.b);
        }

        public static Complex operator -(Complex x,double y)
        {
            return new Complex(x.a - y, x.b);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.a - y.a, x.b - y.b);
        }

        public static Complex operator /(Complex x, Complex y)
        {
            return new Complex(x.a / y.a, x.b / y.b);
        }

    }
}
