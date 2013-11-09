using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class MenuCls
    {
        public int ShowMenu(object hw)
        {
            int command = 0;
            IHomeWork myHW = (IHomeWork)hw;
            string[] hwNames = myHW.GetNames;

            Console.Clear();

            foreach (string item in hwNames)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("0. EXIT");
            Console.WriteLine("\r\nPlease enter:");
            try
            {
                command = Int16.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter valid menu number!");
                Console.ReadLine();
                command = -1;
            }
            Console.Clear();

            myHW.Start(command);
            return command;
        }
    }
}
