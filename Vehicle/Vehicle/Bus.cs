using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace Vehicle
{
    public class Bus : Vehicle, IGasolineVehicle
    {
        public Bus():base()
        {
            HasGasoline = true;
        }

        public Bus(float weight, int maxSpeed, int maxTemperature, int power)
            : base(weight: weight, maxSpeed: maxSpeed, maxTemperature: maxTemperature, power: power)
        {
            HasGasoline = true;
        }

        public override void Drive()
        {
            Console.WriteLine("Bus is running");
        }

        public bool HasGasoline
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Bus speed: " + CurrentSpeed + "\r\n" + Engine.ToString();
        }
    }
}
