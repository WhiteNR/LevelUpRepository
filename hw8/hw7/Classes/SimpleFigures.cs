using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7.Classes
{
    class SimpleFigures
    {
        List<SimpleFigure> simpleFigureList = new List<SimpleFigure>();

        public SimpleFigures(List<SimpleFigure> list)
        {
            simpleFigureList.AddRange(list);
        }

        public double GetArea()
        {
            double areaSum = 0;
            foreach (SimpleFigure item in simpleFigureList)
            {
                areaSum += item.Area;
            }
            return areaSum;
        }
    }
}
