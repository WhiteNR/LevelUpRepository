using hw5.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.USA
{
    public class Washington : City
    {
        public Washington()
        {
            population = 632323;
        }

        public override string ToString()
        {
            return "Washington population = 632323";
        }
    }
}
