using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public delegate void CommonDel();

    public struct MenuItem
    {
        public int MenuItemNumber;
        public string MenuItemName;
        public CommonDel MenuItemDelegate;

        public MenuItem(int menuItemNumber, string menuItemName, CommonDel menuItemDelegate)
        {
            MenuItemNumber = menuItemNumber;
            MenuItemName = menuItemName;
            MenuItemDelegate = menuItemDelegate;
        }

        public override string ToString()
        {
            return MenuItemNumber + ". " + MenuItemName;
        }
    }

    public class MenuCls
    {
        string _header;

        List<MenuItem> _menuList1;

        public MenuCls(string header, List<MenuItem> menuList)
        {
            _menuList1 = menuList;
            _header = header;
        }

        public void ShowMenu()
        {
            int command = 0;
            do
            {
                Console.Clear();

                Console.WriteLine(_header);

                foreach (MenuItem item in _menuList1)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.WriteLine("0. EXIT");
                Console.WriteLine("\r\nPlease enter:");

                try
                {
                    command = Int16.Parse(Console.ReadLine());
                    Console.Clear();
                    if (_menuList1.Exists(x => x.MenuItemNumber == command))
                    {
                        _menuList1.Find(x => x.MenuItemNumber == command).MenuItemDelegate.Invoke();
                        Console.ReadLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter valid menu number!");
                    Console.ReadLine();
                    command = -1;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter valid menu number!");
                    Console.ReadLine();
                    command = -1;
                }
                Console.Clear();
            } while (command != 0);
        }
    }
}
