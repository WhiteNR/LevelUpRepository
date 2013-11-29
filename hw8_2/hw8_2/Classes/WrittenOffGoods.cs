using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8_2.AbstaractClasses;

namespace hw8_2.Classes
{
    public class WrittenOffGoods : Goods
    {
        public WrittenOffGoods()
        {

        }
        public WrittenOffGoods(List<Product> productList)
            : base(productList)
        {

        }
    }
}
