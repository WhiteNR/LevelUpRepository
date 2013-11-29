using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8_2.AbstaractClasses;

namespace hw8_2.Classes
{
    public class Warehouse
    {
        private IncomeGoods _incomeGoods;
        private SoldGoods _soldGoods;
        private TransferredGoods _transferredGoods;
        private WrittenOffGoods _writtenOffGoods;

        public Warehouse()
        {
            _incomeGoods = new IncomeGoods();
            _soldGoods = new SoldGoods();
            _transferredGoods = new TransferredGoods();
            _writtenOffGoods = new WrittenOffGoods();
        }

        public Warehouse(List<Product> incomeGoods)
        {
            _incomeGoods = new IncomeGoods(incomeGoods);
            _soldGoods = new SoldGoods();
            _transferredGoods = new TransferredGoods();
            _writtenOffGoods = new WrittenOffGoods();
        }

        public Warehouse(List<Product> incomeGoods, List<Product> soldGoods, List<Product> transferredGoods, List<Product> writtenOffGoods)
        {
            _incomeGoods = new IncomeGoods(incomeGoods);
            _soldGoods = new SoldGoods(soldGoods);
            _transferredGoods = new TransferredGoods(transferredGoods);
            _writtenOffGoods = new WrittenOffGoods(writtenOffGoods);
        }

        public void AddProduct(Product product)
        {
            _incomeGoods.AddProduct(product);
        }

        public void SellProduct(string productName)
        {
            int index = _incomeGoods.FindProduct(productName);

            if (index != -1)
            {
                _soldGoods.AddProduct(_incomeGoods[index]);
                _incomeGoods.RemoveProduct(index);
            }
        }

        public void TransferProduct(string productName)
        {
            int index = _incomeGoods.FindProduct(productName);

            if (index != -1)
            {
                _transferredGoods.AddProduct(_incomeGoods[index]);
                _incomeGoods.RemoveProduct(index);
            }
        }

        public void WriteOffProduct(string productName)
        {
            int index = _incomeGoods.FindProduct(productName);

            if (index != -1)
            {
                _writtenOffGoods.AddProduct(_incomeGoods[index]);
                _incomeGoods.RemoveProduct(index);
            }
        }

        public List<Product> IncomeGoods { get { return _incomeGoods.GoodsList; } }
        public List<Product> SoldGoods { get { return _soldGoods.GoodsList; } }
        public List<Product> TransferredGoods { get { return _transferredGoods.GoodsList; } }
        public List<Product> WrittenOffGoods { get { return _writtenOffGoods.GoodsList; } }
    }
}
