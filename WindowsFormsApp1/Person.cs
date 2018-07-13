using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person : INotifyPropertyChanged
    {

        String _TCNo;
        String _Name;
        String _Surname;
        String _Gender;
        String _Birthday;

        public event PropertyChangedEventHandler PropertyChanged;

        public String TCNo
        {
            get { return _TCNo; }
            set
            {
                _TCNo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TCNo)));
            }
        }

        public String Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }   
        }

        public String Surname
        {
            get { return _Surname; }
            set
            {
                _Surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
            }
        }

        public String Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Gender)));
            }
        }

        public String Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Birthday)));
            }
        }

    }
}

