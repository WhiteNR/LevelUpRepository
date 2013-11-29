using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw7.AbstractClasses;
using hw7.Exceptions;

namespace hw7.Classes
{
    class Triangle : Figure
    {
        public Triangle(List<Point> pointsList)
        {
            {
                if (pointsList.Count == 3)
                {
                    List<Point> PointsList = new List<Point>();

                    PointsList.AddRange(pointsList);
                    SideSizesList = GetSideSizes(PointsList);
                    if ( SideSizesList[2] >= SideSizesList[0] + SideSizesList[1]  || SideSizesList[1] >= SideSizesList[0] + SideSizesList[2] || SideSizesList[0] >= SideSizesList[2] + SideSizesList[1])
                    {
                        throw new WrongTriengleException("It's not the triangle");
                    }
                    Perimeter = SideSizesList.Sum();
                    Area = GetPolygonArea(PointsList);
                }
                else
                {
                    throw new NotTriengleException("It's not the triangle");
                }
            }
        }

        public List<double> SideSizesList { get; private set; }
        public List<Point> PointsList { get; private set; }
    }
}
