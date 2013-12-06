using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8i.Classes
{
    public class Book : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Author _author;
        private string _bookName;

        public Book()
        {
            _author = new Author();
            _bookName = "";
        }

        public Book(Author author, string bookName)
        {
            _author = author;
            _bookName = bookName;
        }

        public Author BookAuthor
        {
            get { return _author; }
            set { 
                _author = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Book Author"));
                }
            }
        }

        public string BookName
        {
            get { return _bookName; }
            set 
            { 
                _bookName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Book Name"));
                }
            }
        }
        
    }
}
