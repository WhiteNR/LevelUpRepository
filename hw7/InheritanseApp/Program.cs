using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace InheritanseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleSample();
        }

        private static void VehicleSample()
        {
            int command = 0;

            IList<Vehicle.Vehicle> vehicles = new List<Vehicle.Vehicle>();

            vehicles.Add(new Vehicle.Avto(1000));
            vehicles.Add(new Vehicle.Avto(1500, "BMW"));
            vehicles.Add(new Vehicle.Moto());
            vehicles.Add(new Vehicle.Truck());
            vehicles.Add(new Vehicle.Truck(36.5F));
            vehicles.Add(new Vehicle.Bus());
            vehicles.Add(new Vehicle.TrolleyBus());

            foreach (var item in vehicles)
            {
                item.Drive();
            }
            Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine("1. Increase speed.");
                Console.WriteLine("2. Decrease speed.");
                Console.WriteLine("0. Exit.");
                command = Int16.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        foreach (var item in vehicles)
                        {
                            try
                            {
                                item.IncreaseSpeed();
                            }
                            catch (Exception e)
                            {
                                Console.Write(e.Message);
                            }
                            Console.WriteLine("Current speed {0}",item.Speed);
                        }
                        break;
                    case 2:
                         foreach (var item in vehicles)
                        {
                            item.DecreaseSpeed();
                            Console.WriteLine("Current speed {0}", item.Speed);
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (command != 0);


            foreach (var item in vehicles)
            {
                item.Drive();
            }
        }
    }
}
