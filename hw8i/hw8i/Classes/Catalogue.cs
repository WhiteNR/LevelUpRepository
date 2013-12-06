using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8i.Classes
{
    public class Catalogue : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Book> _bookList;

        public Catalogue()
        {
            _bookList = new List<Book>();
        }

        public Catalogue(List<Book> bookList)
        {
            _bookList = bookList;
        }

        public List<Book> BookList 
        {
            get { return _bookList; }
            set 
            { 
                _bookList = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Book Catalogue"));
                }
            }
        }

        public Book this[int index]
        {
            get { return _bookList[index]; }
        }
    }
}
