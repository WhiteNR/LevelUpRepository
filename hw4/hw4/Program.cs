using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = 0;
            HomeWork4 hw4 = new HomeWork4();
            MenuCls menu = new MenuCls();
            do
            {
                command = menu.ShowMenu(hw4);
            } while (command != 0);
        }
    }
}
