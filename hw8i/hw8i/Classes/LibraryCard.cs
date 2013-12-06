using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8i.Classes
{
    public class LibraryCard : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _libraryCardNumber;

        public int LibraryCardNumber
        {
            get { return _libraryCardNumber; }
            set 
            { 
                _libraryCardNumber = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Library Card Number"));
                }
            }
        }
        
    }
}
