using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw7.AbstractClasses;

namespace hw7.Classes
{
    class Circle : Figure
    {
        public Circle(double a)
        {
            A = a;
            Perimeter = 2 * Math.PI * a;
            Area = Math.PI * a * a;
        }
        public double A { get; private set; }
    }
}
