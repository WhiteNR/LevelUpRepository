using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;
using Vehicle;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleSample();
        }

        private static void VehicleSample()
        {
            VehicleList vehicles = new VehicleList();

            foreach (IVehicle item in vehicles)
            {
                item.Stop();
            }

            Console.ReadLine();
            Console.Clear();

            List<MenuItem> menuItems = new List<MenuItem>();

            menuItems.Add(new MenuItem(1, "Increase speed.", new CommonDel(vehicles.IncreaseVehiclesSpeed)));
            menuItems.Add(new MenuItem(2, "Keep current speed.", new CommonDel(vehicles.KeepVehiclesCurrentSpeed)));
            menuItems.Add(new MenuItem(3, "Decrease speed.", new CommonDel(vehicles.DecreaseVehiclesSpeed)));

            MenuCls menuCls = new MenuCls("Vehicle Menu", menuItems);
            menuCls.ShowMenu();
        }
    }
}
