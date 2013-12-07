using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8.Enums;
using hw8.Structures;

namespace hw8
{
    class Program
    {

        /*
        Задание 3. Реализовать метод, который осуществляет поиск элемента в массиве. Ме-
        тод должен принимать массив Object[] array , в котором должен осуществляться поиск,
        и делегат, определяющий, является ли элемент искомым.
        */
        public delegate Boolean Comparer(Object obj, string searchBy);

        static public Boolean ProductComparer(Object obj, string searchBy)
        {
            return ((Article)obj).ProductName == searchBy;
        }


        static void Main(string[] args)
        {
            Object[] products = new Object[5];

            products[0] = new Article("1", "SQL Server 2008 r2", 300, ArticleType.Book);
            products[1] = new Article("2", "SQL Server 2008 r2", 300, ArticleType.Book);
            products[2] = new Article("3", "SQL Server 2005", 160, ArticleType.Book);
            products[3] = new Article("4", "CHIP", 20, ArticleType.Magazine);
            products[4] = new Article("5", "CHIP", 20, ArticleType.Magazine);

            SearchProducts(products, "SQL Server 2008 r2", new Comparer(ProductComparer));

            Console.ReadKey();
        }        
  

        static public void SearchProducts(Object[] array,string searchBy, Comparer comparer)
        {
            foreach (var item in array)
            {
                if (comparer(item, searchBy))
                {
                    Console.WriteLine("Product {0} found.", searchBy);
                }
            }
        }  
    }

}