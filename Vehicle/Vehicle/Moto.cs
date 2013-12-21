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
            HasGasoline = true;
        }

        public Moto(float weight, int maxSpeed, int maxTemperature, int power)
            : base(weight: weight, maxSpeed: maxSpeed, maxTemperature: maxTemperature, power: power)
        {
            HasGasoline = true;
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

        public override string ToString()
        {
            return "Moto speed: " + CurrentSpeed + "\r\n" + Engine.ToString();
        }
    }
}
