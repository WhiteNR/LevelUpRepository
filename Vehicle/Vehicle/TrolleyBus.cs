using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Vehicle
{
    public class TrolleyBus : Vehicle, IElectrVehicle
    {
        public TrolleyBus():base()
        {
            MaxSpeed = 47;
        }

        public bool HasElectrisity
        {
            get;
            set;
        }

        public override void Drive()
        {
            Console.WriteLine("TrolleyBus drive");
        }

        public override void Stop()
        {
            Console.WriteLine("TrolleyBus stop");
        }
    }
}
