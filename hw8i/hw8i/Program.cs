using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw8i.Classes;

namespace hw8i
{
    class Program
    {
        static void Main(string[] args)
        {

            Author author = new Author("Steve", "Balmer");
            author.PropertyChanged += author_PropertyChanged;
            author.AuthorLastName = "aaa";

            Console.ReadKey();
        }

        static void author_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("The property {0} was changed", e.PropertyName);
        }
    }
}

//Интерфейс  INotifyPropertyChanged пространства  имен System.ComponentModel определяет, что наследник содержит событие PropertyChanged, оповещающее об изменении свойств объекта. 
//Изучить данный интерфейс, используя MSDN Library. Проанализировав работу общественных библиотек разработать классы: Author, Book, Client, LibraryCard, Catalogue. 
//Описать их поля, поля инкапсулировать свойствами и для классов реализовать интерфейс INotifyPropertyChanged. Создать диаграмму классов.
