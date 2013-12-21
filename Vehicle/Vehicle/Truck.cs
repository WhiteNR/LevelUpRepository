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
            HasGasoline = true;
        }

        public Truck(float weight, int maxSpeed, int maxTemperature, int power)
            : base(weight: weight, maxSpeed: maxSpeed, maxTemperature: maxTemperature, power: power)
        {
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

        public override void Stop()
        {
            _currentSpeed = 0;
            Console.WriteLine("Truck stopped");
        }

        public float OverWeight { get; set; }

        public bool HasGasoline
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Truck speed: " + CurrentSpeed + "\r\n" + Engine.ToString();
        }
    }
}
