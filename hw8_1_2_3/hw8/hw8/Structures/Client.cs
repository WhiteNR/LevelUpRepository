using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8.Enums;

namespace hw8.Structures
{
    /*1. Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом; общая сумма заказов клиента.*/

    public struct Client
    {
        public int ClientID;
        public string ClientFirstName;
        public string ClientLastName;
        public string ClientFatherName;
        public string ClientAddress;
        public string ClientPhone;
        public int ClientOrdersQty;
        public float ClientOveralldOrdersAmount;
        public ClientType ClientImp;


        public Client(int clientid, string clientfname, string clientlname, string clientmname, string clientaddress, string clientphone, int clientordersqty, float clientoveralldordersamount, ClientType clientimp)
        {
            this.ClientID = clientid;
            this.ClientFirstName = clientfname;
            this.ClientLastName = clientlname;
            this.ClientFatherName = clientmname;
            this.ClientAddress = clientaddress;
            this.ClientPhone = clientphone;
            this.ClientOrdersQty = clientordersqty;
            this.ClientOveralldOrdersAmount = clientoveralldordersamount;
            this.ClientImp = clientimp;
        }

    }
}
