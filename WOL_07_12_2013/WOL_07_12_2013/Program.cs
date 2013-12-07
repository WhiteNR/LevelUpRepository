using Menu;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOL_07_12_2013
{

    class Program
    {

        //public static delegate void MyDel();

        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            List<string> menuItems = new  List<string>();

            Dictionary<int, MenuItem> MyDict = new Dictionary<int, MenuItem>();

            MyDict.Add(1, new MenuItem("DELETE ZERO.",       new CommonDel(cls.DeleteZero)));
            MyDict.Add(2, new MenuItem("SORT.",              new CommonDel(cls.Sort)));
            MyDict.Add(3, new MenuItem("COMPARE.",           new CommonDel(cls.Compare)));
            MyDict.Add(4, new MenuItem("CHANGE COLUMNS.",    new CommonDel(cls.ChangeColumns)));
            MyDict.Add(5, new MenuItem("GET STATISTICS.",    new CommonDel(cls.StringStatistic)));
            MyDict.Add(6, new MenuItem("MODIFY STRING.",     new CommonDel(cls.ModifyString)));

            MenuCls menuCls = new MenuCls("My Menu", MyDict);
            menuCls.ShowMenu();
        }
    }
}
