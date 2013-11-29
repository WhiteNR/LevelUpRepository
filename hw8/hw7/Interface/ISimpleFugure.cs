using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7.Interface
{
    public interface ISimpleFugure
    {
        double Height { get; set; }
        double Foundation { get; set; }
        double Angle { get; set; }
        double Sides { get; set; }
        double Area { get; set; }
        double Perimeter { get; set; }
        List<double> SideSizes { get; set; }
    }
}
