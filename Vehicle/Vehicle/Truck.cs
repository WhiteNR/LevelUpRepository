using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Vehicle
{
    public class Truck : Vehicle, IGasolineVehicle
    {
        public Truck():base()
        {
            MaxSpeed = 62;
            HasGasoline = true;
        }

        public Truck(float weight):this()
        {
            OverWeight = weight;
        }
        public override void Drive()
        {
            Console.WriteLine("Truck is running");
        }
        public float OverWeight { get; set; }

        public bool HasGasoline
        {
            get;
            set;
        }
    }
}
