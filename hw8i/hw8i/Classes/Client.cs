using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8i.Classes
{
    public class Client : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private LibraryCard _clientLibraryCard;
        private List<Book> _clientBookList;

        private string _clientFirstName;
        private string _clientLastName;
        private string _clientFatherName;

        public Client()
        {
            _clientFirstName = "";
            _clientLastName = "";
            _clientFatherName = "";
        }

        public Client(string ClientFirstName, string ClientLastName, string ClientFatherName, LibraryCard ClientLibraryCard)
        {
            _clientFirstName = ClientFirstName;
            _clientLastName = ClientLastName;
            _clientFatherName = ClientFatherName;
            _clientLibraryCard = ClientLibraryCard;
        }

        public string ClientFirstName
        {
            get { return _clientFirstName; }
            set
            {
                _clientFirstName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Client Book List"));
                }
            }
        }

        public string ClientLastName
        {
            get { return _clientLastName; }
            set
            {
                _clientLastName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Client Book List"));
                }
            }
        }

        public string ClientFatherName
        {
            get { return _clientFatherName; }
            set
            {
                _clientFatherName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Client Book List"));
                }
            }
        }

        public List<Book> ClientBookList
        {
            get { return _clientBookList; }
            set 
            { 
                _clientBookList = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Client Book List"));
                }
            }
        }

        public LibraryCard ClientLibraryCard
        {
            get { return _clientLibraryCard; }
            set 
            { 
                _clientLibraryCard = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Library Card"));
                }
            }
        }
        
    }
}
