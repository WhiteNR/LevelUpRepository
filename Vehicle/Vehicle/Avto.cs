using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle 
{
    public class Avto: Vehicle,IGasolineVehicle
    {
        protected string manufactureName;

        public Avto():base()
        {
            MaxSpeed = 160;
        }

        public Avto(float weight): base(weight: weight)
        {
            MaxSpeed = 160;
        }

        public Avto(float weight, string manufactureName):this(weight: weight)
        {
            this.manufactureName = manufactureName;
        }

        public override void Drive()
        {
            Console.WriteLine("Avto is running");
        }


        public override void Stop()
        {
            Console.WriteLine("Avto was stopped.");
        }

        public bool HasGasoline
        {
            get;
            set;
        }
    }
}
