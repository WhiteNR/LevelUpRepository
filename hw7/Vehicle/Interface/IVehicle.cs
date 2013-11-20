using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public interface IVehicle
    {
        void Drive();

        void Stop();

        void IncreaseSpeed();

        void DecreaseSpeed();

        int Speed { get; set; }
        int Temperature { get; set; }
        bool IsBroken { get; set; }
    }
}
