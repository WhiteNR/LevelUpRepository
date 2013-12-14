using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace Vehicle
{
    public class Bus : Vehicle,IGasolineVehicle
    {
        public Bus():base()
        {
            MaxSpeed = 62;
            HasGasoline = true;
        }
        public override void Drive()
        {
            Console.WriteLine("Bus is running");
        }

        public override void Stop()
        {
            Console.WriteLine("Bus was stopped");
        }

        public bool HasGasoline
        {
            get;
            set;
        }
    }
}
