using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw7.AbstractClasses;

namespace hw7.Classes
{
    class Ellipse : Figure
    {
        public Ellipse(double a, double b)
        {
            A = a;
            B = b;
            Perimeter = 4 * ((Math.PI * a * b + Math.Pow(a - b, 2)) / (a + b));
            Area = Math.PI * a * b;
        }

        public double A { get; private set; }
        public double B { get; private set; }
    }
}
