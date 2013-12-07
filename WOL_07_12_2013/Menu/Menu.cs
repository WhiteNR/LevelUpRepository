using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Menu
{
    public delegate void CommonDel();

    public class MenuCls
    {

        Dictionary<int, MenuItem> _menuDict;

        string _header;

        public MenuCls(string header, Dictionary<int, MenuItem> menuDict)
        {
            _menuDict = menuDict;
            _header = header;
        }

        public void ShowMenu()
        {
            int command = 0;
            do
            {
                Console.Clear();

                Console.WriteLine(_header);

                foreach (int item in _menuDict.Keys)
                {
                    Console.WriteLine(item + ". " + _menuDict[item].MenuItemName);
                }

                Console.WriteLine("0. EXIT");
                Console.WriteLine("\r\nPlease enter:");

                try
                {
                    command = Int16.Parse(Console.ReadLine());
                    Console.Clear();
                    if (_menuDict.ContainsKey(command))
                    {
                        _menuDict[command].MenuItemDelegate.Invoke();
                    }
                    Console.ReadLine();
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
