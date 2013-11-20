using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Vehicle
{
    public abstract class Vehicle: IVehicle
    {
        private readonly float weight;

        public Vehicle()
        {
            MaxSpeed = 30;
            IsBroken = false;
            Temperature = 80;
            Speed = 0;
        }

        public Vehicle(float weight):this()
        {
            this.weight = weight;
        }

        public float Weight
        {
            get { return weight; }
        }

        public virtual void Drive()
        {
            Console.WriteLine("Base drive");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Base stop");
        }

        public void IncreaseSpeed()
        {
            if (Temperature < 120 && !IsBroken)
            {
                if (Speed + 10 < MaxSpeed)
                {
                    Speed += 10;
                }
                else if (Speed == MaxSpeed)
                {
                    Temperature += 5;
                    throw new Exception("Max speed is reached. Engine temperature is:" + Temperature.ToString() + " (vehicle blow up on 120) ");
                }
                else
                {
                    Speed = MaxSpeed;
                }
            }
            else
            { 
                IsBroken = true;
                Speed = 0;
                throw new Exception("Vehicle blowed up!!!! ");
            }
        }

        public void DecreaseSpeed()
        {
            if (Speed - 10 > 0)
            {
                Speed -= 10;
            }
            else
            {
                Speed = 0;
            }
        }

        public int MaxSpeed { get; protected set; }

        public int Speed { get; set; }
        public int Temperature { get; set; }
        public bool IsBroken { get; set; }
    }
}