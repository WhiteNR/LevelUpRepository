using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public struct MenuItem
    {
        public CommonDel MenuItemDelegate;
        public string MenuItemName;

        public MenuItem(string menuItemName, CommonDel menuItemDelegate)
        {
            MenuItemName = menuItemName;
            MenuItemDelegate = menuItemDelegate;
        }
    }
}
