using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8.Enums;

namespace hw8.Structures
{
    /*1. Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.*/
    public struct Article
    {
        public string ProductID;
        public string ProductName;
        public float ProductPrice;
        public ArticleType ArtType;

        public Article(String prodid, String prodname, float prodprice, ArticleType arttype)
        {
            this.ProductID = prodid;
            this.ProductName = prodname;
            this.ProductPrice = prodprice;
            this.ArtType = arttype;
        }

    }
}
