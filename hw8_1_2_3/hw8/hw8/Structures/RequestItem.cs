using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8.Structures
{
    /*1. Описать структуру RequestItem содержащую поля: товар; количество единиц товара. */
    public struct RequestItem
    {
        public int ProdID;
        public int ProdQty;

        public RequestItem(int prodid, int prodqty)
        {
            this.ProdID = prodid;
            this.ProdQty = prodqty;

        }
    }
}
