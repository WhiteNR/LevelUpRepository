using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Vehicle
{
    public class Moto : Vehicle, IGasolineVehicle
    {
        public Moto():base()
        {
            MaxSpeed = 140;
        }

        public override void Drive()
        {
            Console.WriteLine("Moto is running");
        }


        public override void Stop()
        {
            Console.WriteLine("Moto was stopped.");
        }

        public bool HasGasoline
        {
            get;
            set;
        }
    }
}
