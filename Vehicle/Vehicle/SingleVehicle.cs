using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace Vehicle
{
    public class SingleVehicle
    {

        TrafficLight _trafficLight;
        MenuCls singleVehicleMenu;
        IVehicle _vehicle;

        public SingleVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
            _trafficLight = new TrafficLight(StopVehicle);
            List<MenuItem> singleVehicleMenuItems = new List<MenuItem>();
            singleVehicleMenuItems.Add(new MenuItem(1, "Increase Vehicle Speed.", new CommonDel(IncreaseVehicleSpeed)));
            singleVehicleMenuItems.Add(new MenuItem(2, "Keep Vehicle Current Speed.", new CommonDel(KeepVehicleCurrentSpeed)));
            singleVehicleMenuItems.Add(new MenuItem(3, "Decrease Vehicle Speed.", new CommonDel(DecreaseVehicleSpeed)));
            singleVehicleMenu = new MenuCls("Vehicle Menu", singleVehicleMenuItems);
        }

        public void ShowMenu()
        {
            singleVehicleMenu.ShowMenu();
        }

        public void IncreaseVehicleSpeed()
        {
            if (!_trafficLight.TrafficLightWork())
            {
                Console.WriteLine(_trafficLight.Lights.ToString());
                Console.WriteLine();
                try
                {
                    _vehicle.IncreaseSpeed();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.Write(e.Message);
                }
                Console.WriteLine(_vehicle.ToString());
                Console.WriteLine();
            }
        }

        public void DecreaseVehicleSpeed()
        {
            if (!_trafficLight.TrafficLightWork())
            {
                Console.WriteLine(_trafficLight.Lights.ToString());
                Console.WriteLine();
                try
                {
                    _vehicle.DecreaseSpeed();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                Console.WriteLine(_vehicle.ToString());
                Console.WriteLine();
            }
        }

        public void KeepVehicleCurrentSpeed()
        {
            if (!_trafficLight.TrafficLightWork())
            {
                Console.WriteLine(_trafficLight.Lights.ToString());
                Console.WriteLine();
                try
                {
                    _vehicle.KeepCurrentSpeed();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                Console.WriteLine(_vehicle.ToString());
                Console.WriteLine();
            }
        }

        public void StopVehicle()
        {
            Console.WriteLine(_trafficLight.Lights.ToString());
            Console.WriteLine();
            try
            {
                if (_trafficLight.Lights == TrafficLight.TrafficLights.Yellow)
                {
                    _vehicle.Breake();
                }
                else if (_trafficLight.Lights == TrafficLight.TrafficLights.Red)
                {
                    _vehicle.Stop();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.Write(e.Message);
            }
            Console.WriteLine(_vehicle.ToString());
            Console.WriteLine();
        }
    }
}

    

