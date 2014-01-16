using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle 
{
    public class Avto: Vehicle, IGasolineVehicle
    {
        protected string manufactureName;

        public Avto():base()
        {
        }

        public Avto(float weight, int maxSpeed, int maxTemperature, int power)
            : base(weight: weight, maxSpeed: maxSpeed, maxTemperature: maxTemperature, power: power)
        {
        }

        public Avto(float weight, string manufactureName, int maxSpeed, int maxTemperature, int power)
            : this(weight: weight, maxSpeed: maxSpeed, maxTemperature: maxTemperature, power: power)
        {
            this.manufactureName = manufactureName;
        }

        public override void Drive()
        {
            Console.WriteLine("Avto is running");
        }

        public bool HasGasoline
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Auto speed: " + CurrentSpeed + "\r\n" + Engine.ToString();
        }
    }
}
