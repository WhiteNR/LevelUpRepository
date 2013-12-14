using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.Countries
{
    public class City : IComparable
    {
        protected long population;

        public City()
        {
            population = 0;
        }

        public int CompareTo(object obj)
        {
            City city = obj as City;
            if (city == null)
            {
                throw new FormatException("Wrong object.");
            }

            if (this.population > city.population)
            {
                return 1;
            }
            else if (this.population == city.population)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return "Base class.";
        }
    }
}
