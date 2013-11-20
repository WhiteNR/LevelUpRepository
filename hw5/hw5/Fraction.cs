using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class Fraction
    {
        long a, b;

        public Fraction(long x, long y)
        {
            a = x;
            b = y;
            divReduction(this);
        }

        private void divReduction(Fraction fraction)
        {
            long divisor = findGreatestCommonDivisor(fraction.a, fraction.b);

            a = a / divisor;
            b = b / divisor;
        }

        public override string ToString()
        {
            if (this.a == 0 || this.b == 0)
            {
                return String.Format("0");
            }
            else
            {
                return String.Format("{0}/{1}", this.a, this.b);
            }
        }

        public static long findGreatestCommonDivisor(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Fraction ToDiv(double div)
        {
            long divCount = 1;
            while (div % 1 > 0)
            {
                div *= 10;
                divCount *= 10;
            }
            return new Fraction(Convert.ToInt64(div), divCount);
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
            return x * ToDiv(y);
        }

        public static Fraction operator *(double x, Fraction y)
        {
            return ToDiv(x) * y;
        }

        public static Fraction operator *(Fraction x, Fraction y)
        {
            return new Fraction(x.a * y.a, x.b * y.b);
        }

        public static Fraction operator +(Fraction x, double y)
        {
            return x + ToDiv(y);
        }

        public static Fraction operator +(Fraction x, Fraction y)
        {
            return new Fraction(x.a * y.b + y.a * x.b, x.b * y.b);
        }

        public static Fraction operator -(Fraction x, double y)
        {
            return x - ToDiv(y);
        }

        public static Fraction operator -(Fraction x, Fraction y)
        {
            return new Fraction(x.a * y.b - y.a * x.b, x.b * y.b);
        }

        public static Fraction operator /(Fraction x, double y)
        {
            return x / ToDiv(y);
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
