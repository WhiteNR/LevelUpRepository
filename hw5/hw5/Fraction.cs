using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Fraction
    {
        double result,a, b;

        public Fraction(double x, double y)
        {
            a = x;
            b = y;
        }

        public static bool operator true(Fraction x)
        { 
            return x.a < x.b;
        }
        public static bool operator false(Fraction x)
        {
            return x.a > x.b;
        }

        public static Fraction operator *(Fraction x, double y)
        {
            return new Fraction(x.a * y, x.b);
        }

        public static Fraction operator *(double x, Fraction y)
        {
            return new Fraction(y.a * x, y.b);
        }

        public static Fraction operator +(Fraction x, double y)
        {
            return new Fraction(x.a + y * x.b, x.b);
        }

        public static Fraction operator +(Fraction x, Fraction y)
        {
            return new Fraction(x.a * y.b + y.a * x.b, x.b * y.b);
        }

        public static Fraction operator -(Fraction x, double y)
        {
            return new Fraction(x.a - y * x.b, x.b);
        }

        public static Fraction operator -(Fraction x, Fraction y)
        {
            return new Fraction(x.a * y.b - y.a * x.b, x.b * y.b);
        }

        public static Fraction operator /(Fraction x, double y)
        {
            return new Fraction(x.a, x.b * y);
        }

        public static Fraction operator /(Fraction x, Fraction y)
        {
            return new Fraction(x.a * y.b, x.b * y.a);
        }
        public static bool operator ==(Fraction x, Fraction y)
        {
            return x.a == y.a && x.b == y.b;
        }

        public static bool operator !=(Fraction x, Fraction y)
        {
            return x.a != y.a || x.b != y.b;
        }

        public static bool operator >(Fraction x, Fraction y)
        {
            return x.a * y.b > x.b * y.a;
        }

        public static bool operator <(Fraction x, Fraction y)
        {
            return x.a * y.b < x.b * y.a;
        }
    }
}
