using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw7.Interface;

namespace hw7.Classes
{
    class SimpleFigure : ISimpleFugure
    {
        public double Height
        {
            get;
            set;
        }

        public double Foundation
        {
            get;
            set;
        }


        public double Angle
        {
            get;
            set;
        }


        public double Sides
        {
            get;
            set;
        }


        public double Area
        {
            get;
            set;
        }


        public double Perimeter
        {
            get;
            set;
        }


        public List<double> SideSizes
        {
            get;
            set;
        }
    }
}

