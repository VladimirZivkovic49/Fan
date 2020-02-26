using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.Skaliranje.SkaliranjeModels
{


    // svojstva za binding vrednosti RadioButtons prozora  Skaliranje/SkaliranjeWindow.xml
    public class RadioCheckSkaliranje:INotifyPropertyChanged
    {

        private bool check1;
        public bool Check1
        {
            get { return check1; }
            set
            {
                check1 = value;
                OnPropertyChanged("Check1");

            }
        }

        private bool check2;
        public bool Check2
        {
            get { return check2; }
            set
            {
                check2 = value;
                OnPropertyChanged("Check2");

            }
        }

        private bool check3;
        public bool Check3
        {
            get { return check3; }
            set
            {
                check3 = value;
                OnPropertyChanged("Check3");

            }
        }

        private bool check4;
        public bool Check4
        {
            get { return check4; }
            set
            {
                check4 = value;
                OnPropertyChanged("Check4");

            }
        }

        private bool check5;
        public bool Check5
        {
            get { return check5; }
            set
            {
                check5 = value;
                OnPropertyChanged("Check5");

            }
        }

        private bool check6;
        public bool Check6
        {
            get { return check6; }
            set
            {
                check6 = value;
                OnPropertyChanged("Check6");

            }
        }

        private bool check7;
        public bool Check7
        {
            get { return check7; }
            set
            {
                check7 = value;
                OnPropertyChanged("Check7");

            }
        }

        private bool check8;
        public bool Check8
        {
            get { return check8; }
            set
            {
                check8 = value;
                OnPropertyChanged("Check8");

            }
        }

        private bool check9;
        public bool Check9
        {
            get { return check9; }
            set
            {
                check9 = value;
                OnPropertyChanged("Check9");

            }
        }











        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void RaisePropertyChanged(
             [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(caller));

            }

        }











    }
}
