using System;

namespace hw8
{
    public class StructDefinition
    {
        public StructDefinition()
        {
        }

        /*Описать структуру Article, содержащую следующие поля: код товара; на-
                звание товара; цену товара.*/

        private struct Article
        {
            public string ProdID;
            public string ProdName;
            public float ProdPrice;

            public Article(String prodid, String prodname, float prodprice)
            {
                this.ProdID = prodid;
                this.ProdName = prodname;
                this.ProdPrice = prodprice;
            }
        }

        /*Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количе-
        ство заказов осуществленных клиентом; общая сумма заказов клиента.*/

        private struct Client
        {
            public int ClientID;
            public string ClientFName;
            public string ClientLName;
            public string ClientMName;
            public string ClientAddress;
            public string ClientPhone;
            public int ClientOrdersQty;
            public float ClientOveralldOrdersAmount;


            public Client(int clientid, string clientfname, string clientlname, string clientmname, string clientaddress, string clientphone, int clientordersqty, float clientoveralldordersamount)
            {
                this.ClientID = clientid;
                this.ClientFName = clientfname;
                this.ClientLName = clientlname;
                this.ClientMName = clientmname;
                this.ClientAddress = clientaddress;
                this.ClientPhone = clientphone;
                this.ClientOrdersQty = clientordersqty;
                this.ClientOveralldOrdersAmount = clientoveralldordersamount;

            }
        }


        /*Описать структуру RequestItem содержащую поля: товар; количество единиц товара. */
        private struct RequestItem
        {
            public int ProdID;
            public int ProdQty;

            public RequestItem(int prodid, int prodqty)
            {
                this.ProdID = prodid;
                this.ProdQty = prodqty;

            }
        }

        /*Описать структуру Request содержащую поля: код заказа; клиент;  дата заказа; перечень заказанных товаров; сумма заказа (реализовать вычисляемым свойством).*/
        private struct Request
        {
            public int OrderID;
            public int ClientID;
            public int OrderDate;
            public RequestItem Prods;
            public Prods.ProdQty ProdQty;
            public float ProdPrice;

            public float OrderSum
            {
                get
                {
                    return ProdQty * ProdPrice;
                }
            }


            public Request(int orderid, int clientid, datetime orderdate, RequestItem prods, float prodprice)
            {
                this.OrderID = orderid;
                this.ClientID = clientid;
                this.OrderDate = orderdate;
                this.Prods = prods;
                this.ProdPrice = prodprice;
            }
        }


    }
}