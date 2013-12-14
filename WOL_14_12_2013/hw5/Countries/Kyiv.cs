using hw5.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Ukraine
{
    public class Kyiv : City
    {
        public Kyiv()
        {
            population = 2758000;
        }

        public override string ToString()
        {
            return "Kyiv population = 2758000";
        }
    }
}
