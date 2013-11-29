using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_2.AbstaractClasses
{
    public abstract class Goods
    {
        private List<Product> _goodsList;

        public Goods()
        {
            _goodsList = new List<Product>();
        }

        public Goods(List<Product> goodsList):this()
        {
            _goodsList.AddRange(goodsList);
        }

        public Product this[int index]
        {
            set
            {
                _goodsList[index] = value;
            }

            get
            {
                return _goodsList[index];
            }
        }

        public void RemoveProduct(int index)
        {
            _goodsList.RemoveAt(index);
        }

        public void AddProduct(Product product)
        {
            _goodsList.Add(product);
        }

        public int FindProduct(string productName)
        {
            int ret = -1;
            for (int i = _goodsList.Count - 1; i >= 0; i--)
            {
                if (_goodsList[i].Name == productName)
                {
                    ret = i;
                    break;
                }
            }
            return ret;
        }
        public List<Product> GoodsList { get { return _goodsList; } }
    }
}
