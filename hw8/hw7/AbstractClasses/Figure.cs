using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw7.AbstractClasses
{
    public abstract class Figure
    {
        public Figure()
        {
            Perimeter = 0;
            Area = 0;
        }

        protected List<double> GetSideSizes(List<Point> _pointsList)
        {
            List<double> sideSizeList = new List<double>();
            Point p1, p2;

            if (_pointsList.Count > 2)
            {
                p1 = _pointsList.Last();
            }
            else
            {
                p1 = _pointsList.First();
            }

            foreach (Point item in _pointsList)
            {
                p2 = item;
                sideSizeList.Add(LineLength(p1, p2));
                p1 = item;
            }
            return sideSizeList;
        }

        protected double GetPolygonArea(List<Point> pointsList)
        {
            double halfPerimeter, tempArea = 0;
            Point p1, p2, p3;
            double sideA, sideB, sideC;

            if (pointsList.Count < 3)
            {
                return 0;
            }
            p1 = pointsList[0];
            p2 = pointsList[1];
            for (int i = 2; i < pointsList.Count; i++)
            {
                p3 = pointsList[i];
                sideA = LineLength(p1, p2);
                sideB = LineLength(p2, p3);
                sideC = LineLength(p3, p1);
                halfPerimeter = (sideA + sideB + sideC) / 2;
                tempArea += Math.Sqrt(halfPerimeter*((halfPerimeter - sideA)*(halfPerimeter - sideB)*(halfPerimeter - sideC)));
                p2 = pointsList[i];
            }
            return tempArea;
        }

        private double LineLength(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public double Perimeter { get; protected set; }
        public double Area { get; protected set; }
    }
}
