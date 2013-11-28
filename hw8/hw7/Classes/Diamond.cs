using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw7.AbstractClasses;

namespace hw7.Classes
{
    class Diamond : Figure
    {
        public Diamond(List<Point> pointsList)
        {
            if (pointsList.Count == 4)
            {
                List<Point> PointsList = new List<Point>();

                PointsList.AddRange(pointsList);
                SideSizesList = GetSideSizes(PointsList);
                Perimeter = SideSizesList.Sum();
                Area = GetPolygonArea(PointsList);
            }
            else
            {
                throw new Exception("It's not the diamond");
            }
        }

        public List<double> SideSizesList { get; private set; }
        public List<Point> PointsList { get; private set; }
    }
}
