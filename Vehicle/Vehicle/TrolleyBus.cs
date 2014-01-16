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
        }

        public TrolleyBus(float weight, int maxSpeed, int maxTemperature, int power)
            : base(weight: weight, maxSpeed: maxSpeed, maxTemperature: maxTemperature, power: power)
        {
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

        public override string ToString()
        {
            return "Trolley Bus speed: " + CurrentSpeed + "\r\n" + Engine.ToString();
        }
    }
}
