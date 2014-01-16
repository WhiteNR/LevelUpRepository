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

        void KeepCurrentSpeed();

        void Breake();
    }
}
