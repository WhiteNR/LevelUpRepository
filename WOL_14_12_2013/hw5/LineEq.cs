using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
{
    class LineEq
    {
        public static string CountLineEq(Struct ab1, Struct ab2, int c1, int c2)
        {
         /*
         A1×X + B1×Y = C1
         A2×X + B2×Y = C2
         */
            int x = 0;
            int y = 0;
            try
            {
                x = ((c1 * ab2.B) - (ab1.B * c2)) / ((ab1.A * ab2.B) - (ab1.B * ab2.A));
                y = ((ab1.A * c2) - (ab2.B * ab2.A)) / ((ab1.A * ab2.B) - (ab1.B * ab2.A));

                if (((ab1.A * x + ab1.B * y) == c1) || (ab2.A * x + ab2.B * y) == c2)
                    return "Solution found: " + "\r\n" + "x = " + x + "\r\n" + "y = " + y;
                else
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException e)
            {
                return "Arguments out of range error. Message: " + e.Message + "\r\n";
            }
            catch (DivideByZeroException e)
            {
                return "Divide by zero error. Message:" + e.Message + "\r\n";
            }
        }
    }
}
