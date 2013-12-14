using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wonders.Wonders;
namespace Wonders
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ChinaWall chinaWall = new ChinaWall();
            HangingGardens hangingGardens = new HangingGardens();
            Kolosus kolosus = new Kolosus();
            Piramids piramids = new Piramids();
            TadjMahal tadjMahal = new TadjMahal();
            Wonder wonder = new Wonder();
            ZeusStatue zeusStatue = new ZeusStatue();
        }
    }
}
