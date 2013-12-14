using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface I2DPoint<T>
    {
        T Length<T>(T int);
        void Draw();
    }
}
