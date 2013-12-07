using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8.Enums;

namespace hw8.Structures
{
    /*1. Описать структуру Request содержащую поля: код заказа; клиент;  дата заказа; перечень заказанных товаров; сумма заказа (реализовать вычисляемым свойством).*/
    public struct Request
    {
        public int OrderID;
        public int ClientID;
        public DateTime OrderDate;
        public RequestItem Products;
        public int ProductQty;
        public float ProductPrice;
        public PayType PmtType;

        public float OrderSum
        {
            get
            {
                return ProductQty * ProductPrice;
            }
        }

        public Request(int orderid, int clientid, DateTime orderdate, RequestItem prods, float prodprice, int prodqty, PayType pmttype)
        {
            this.OrderID = orderid;
            this.ClientID = clientid;
            this.OrderDate = orderdate;
            this.Products = prods;
            this.ProductPrice = prodprice;
            this.ProductQty = prodqty;
            this.PmtType = pmttype;
        }
    }
}
