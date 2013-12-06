using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8i.Classes
{
    public class Author : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _authorFirstName;
        private string _authorLastName;
        private string _authorFatherName;

        public Author()
        {
            _authorFirstName = "";
            _authorLastName = "";
            _authorFatherName = "";
        }

        public Author(string AuthorFirstName, string AuthorLastName)
            : this()
        {
            _authorFirstName = AuthorFirstName;
            _authorLastName = AuthorLastName;
        }

        public Author(string AuthorFirstName, string AuthorLastName, string AuthorFatherName)
            : this()
        {
            _authorFirstName = AuthorFirstName;
            _authorLastName = AuthorLastName;
            _authorFatherName = AuthorFatherName;
        }

        public string AuthorFirstName
	    {
		    get { return _authorFirstName;}
		    set 
            { 
                _authorFirstName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Author First Name"));
                }
            }
	    }

        public string AuthorLastName
        {
            get { return _authorLastName; }
            set 
            { 
                _authorLastName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Author Last Name"));
                }
            }
        }

        public string AuthorFatherName
        {
            get { return _authorFatherName; }
            set 
            { 
                _authorFatherName = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Author Father Name"));
                }
            }
        }
        
    }
}
