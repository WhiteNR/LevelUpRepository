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
            SingleVehicle singleVehicle;
            MenuCls commonMenuCls, chooseVehicleMenuCls;
            foreach (IVehicle item in vehicles)
            {
                item.Stop();
            }

            Console.ReadLine();
            Console.Clear();

            List<MenuItem> chooseVehicleMenuItems = new List<MenuItem>();
            chooseVehicleMenuItems.Add(new MenuItem(1, "Auto.", new CommonDel(() => { singleVehicle = new SingleVehicle(new Avto()); singleVehicle.ShowMenu(); })));
            chooseVehicleMenuItems.Add(new MenuItem(2, "Bus.", new CommonDel(() => { singleVehicle = new SingleVehicle(new Bus()); singleVehicle.ShowMenu(); })));
            chooseVehicleMenuItems.Add(new MenuItem(3, "Moto.", new CommonDel(() => { singleVehicle = new SingleVehicle(new Moto()); singleVehicle.ShowMenu(); })));
            chooseVehicleMenuItems.Add(new MenuItem(4, "TrolleyBus.", new CommonDel(() => { singleVehicle = new SingleVehicle(new TrolleyBus()); singleVehicle.ShowMenu(); })));
            chooseVehicleMenuItems.Add(new MenuItem(5, "Truck.", new CommonDel(() => { singleVehicle = new SingleVehicle(new Truck()); singleVehicle.ShowMenu(); })));
            chooseVehicleMenuCls = new MenuCls("Choose Vehicle", chooseVehicleMenuItems);

            List<MenuItem> commonMenuItems = new List<MenuItem>();
            commonMenuItems.Add(new MenuItem(1, "Start AutoDrive.", new CommonDel(vehicles.StartDriving)));
            commonMenuItems.Add(new MenuItem(2, "Drive single vehicle.", new CommonDel(chooseVehicleMenuCls.ShowMenu)));
            commonMenuCls = new MenuCls("Vehicle Menu", commonMenuItems);

            commonMenuCls.ShowMenu();
        }
    }
}

//Реализуйте программу имитирующую  движение транспортных средств на дороге управляемых светофором. 
//При смене сигналов светофора, все транспортные средства в зависимости от сигнала светофора должны: 
//1.       Светофор сменил сигнал с зелёного на мигающий желтый – транспортные средства (ТС) замедляют свою текущую скорость. 
//2.       Светофор сменил сигнал с мигающего желтого на красный – ТС должны остановиться 
//3.       Светофор сменил с мигающего желтого на зеленый – все транспортные средства поехали. 
//Реализовать в программе следующие абстракции: 
//Тип  - Двигатель (Engine)  
//Тип - Транспортное средство (Vehicle) 
//Тип - Легковой автомобиль (Car) 
//Тип – Грузовик (Trunk) 
//Тип – мотоцикл (motorcycle) 
//Тип – Автобус (autobus) 
//Тип – Светофор (semaphore) 
  
//Программа должна иметь возможность создавать во времени выполнения 10 транспортных средств, которые будут двигаться по автомобильной дороге. 
//При этом запуск имитации движения, остановка и вывод информации о дорожном движении должен производиться из главного меню программы. 
//При этом пользователь может выбрать любое транспортное средство и произвести имитацию его управления (разогнать транспортное средство, остановить). 
//Данные функции должны быть доступны из вложенного меню. Когда пользователь управляет ТС на экран должна выводиться следующая информация: 
//•         Марка транспортного средства 
//•         Название марки 
//•         Тип и объем двигателя 
//•         Текущая скорость ТС 
//•         Температура двигателя 
//Если текущая скорость ТС является максимальной происходит нагрев двигателя. 
//При перегреве двигателя ТС останавливается и движение может быть продолжено только после того как температура двигателя станет в пределах нормы ( t < 92 ) 
//Во время движения управляемое ТС должно так-же как и все остальные средства реагировать на сигнал светофора. 

//Для всех созданных абстракций и пользовательских типов необходимо создать схему (VS)
