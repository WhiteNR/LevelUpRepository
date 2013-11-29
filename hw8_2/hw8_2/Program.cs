using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8_2.AbstaractClasses;
using hw8_2.Classes;

namespace hw8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Dishes("Dish", 5, 40.2m));
            productList.Add(new Dishes("Dish1", 10, 41.2m));
            productList.Add(new Food("Dish1", 40, 1.2m));

            Warehouse warehouse = new Warehouse(productList);
            List<Product> Income = warehouse.IncomeGoods;


            foreach (var item in Income)
            {
                Console.WriteLine("Product name: {0}  number: {1} price:{2}", item.Name, item.Number,item.Price);
            }

        }
    }
}

/*
 * Задание 3. Разработать архитектуру классов иерархии товаров при разработке системы  управления  потоками  товаров  для  дистрибьюторской  компании.  Прописать  члены классов. Создать диаграммы взаимоотношений классов и интерфейсов.

Должны быть предусмотрены разные типы товаров, в том числе:

•	бытовая химия,

•	продукты питания.

Предусмотреть интерфейсы:

•	скоропортящиеся продукты,

•	ликероводочные продукты и табачные изделия (акцизные продукты),

•	легковоспламеняющиеся товары,

•	бьющиеся товары.

Предусмотреть классы управления потоком товаров (пришло, реализовано, списано, передано).

Реализовать собственные классы исключений:

•	«нет в наличие»,

•	«истек срок годности»,

•	«бракованный товар».


 * */
