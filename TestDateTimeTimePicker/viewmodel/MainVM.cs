using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestDateTimeTimePicker.Annotations;

namespace TestDateTimeTimePicker.viewmodel
{
    class MainVM : INotifyPropertyChanged
    {
        private DateTimeOffset _datoTid;
        private TimeSpan _tid;
        private String _dtTxt;
        private String _timeTxt;
        private DateTime _dateTimeValue;
        

        public MainVM()
        {
            _datoTid = new DateTimeOffset(new DateTime(2019,1,1));
            DateTime dt = DateTime.Now;
            _tid = new TimeSpan(dt.Hour, dt.Day, dt.Minute);
            _dateTimeValue = DateTime.Now;
        }

        public DateTime DateTimeValue
        {
            get => _dateTimeValue;
            set
            {
                _dateTimeValue = value;
                DtTxt = _dateTimeValue.ToString("PETER:: yyyy-MM-dd");
                OnPropertyChanged();
            }
        }


        public string DtTxt
        {
            get => _datoTid.ToString();
            set { _dtTxt = value; OnPropertyChanged();}
        }

        public string TimeTxt
        {
            get => _tid.ToString();
            set { _timeTxt = value; OnPropertyChanged();}
        }

        public DateTimeOffset DatoTid
        {
            get => _datoTid;
            set { _datoTid = value;
                OnPropertyChanged();
                OnPropertyChanged("DtTxt");
            }
        }

        public TimeSpan Tid
        {
            get => _tid;
            set
            {
                _tid = value;
                OnPropertyChanged();
                OnPropertyChanged("TimeTxt");
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
