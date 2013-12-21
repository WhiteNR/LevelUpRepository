using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class VehicleList : IEnumerable
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        TrafficLight _trafficLight;

        public VehicleList()
        {
            _trafficLight = new TrafficLight(StopVehicles);
            vehicles.Add(new Avto(100, "Mersedes", 300, 120, 30));
            vehicles.Add(new Avto(1500, "BMW",250,120,20));
            vehicles.Add(new Moto(150,180,130,20));
            vehicles.Add(new Truck(5000,95,130,8));
            vehicles.Add(new Truck(9000,45,150,5));
            vehicles.Add(new Bus(3000,70,120,8));
            vehicles.Add(new TrolleyBus(4000,50,200,10));
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Vehicle item in vehicles)
            {
                yield return item;
            }
        }

        public void IncreaseVehiclesSpeed()
        {
            if (!_trafficLight.TrafficLightWork())
            {
                foreach (IVehicle item in vehicles)
                {
                    try
                    {
                        item.IncreaseSpeed();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.Write(e.Message);
                    }
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

        public void DecreaseVehiclesSpeed()
        {
            if (!_trafficLight.TrafficLightWork())
            {
                foreach (IVehicle item in vehicles)
                {
                    try
                    {
                        item.DecreaseSpeed();
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

        public void KeepVehiclesCurrentSpeed()
        {
            if (!_trafficLight.TrafficLightWork())
            {
                foreach (IVehicle item in vehicles)
                {
                    try
                    {
                        item.KeepCurrentSpeed();
                    }
                    catch (Exception e)
                    {
                        Console.Write(e.Message);
                    }
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

        public void StopVehicles()
        {
            foreach (IVehicle item in vehicles)
            {
                try
                {
                    item.Stop();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.Write(e.Message);
                }
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }
    }
}
