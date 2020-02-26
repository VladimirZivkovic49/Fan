using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMImage.Skaliranje.SkaliranjeModels
{
    public class GridsVisability:INotifyPropertyChanged
    {
        private Visibility _gridVisability;
        public Visibility gridVisability
        {
            get { return _gridVisability; }
            set
            {
                _gridVisability = value;
                OnPropertyChanged("gridVisability");
            }
        }

        private Visibility _gridVisabilityPow;
        public Visibility gridVisabilityPow
        {
            get { return _gridVisabilityPow; }
            set
            {
                _gridVisabilityPow = value;
                OnPropertyChanged("gridVisabilityPow");
            }
        }

        private Visibility _gridVisabilityProveraSkaliranja;
        public Visibility gridVisabilityProveraSkaliranja
        {
            get { return _gridVisabilityProveraSkaliranja; }
            set
            {
                _gridVisabilityProveraSkaliranja = value;
                OnPropertyChanged("gridVisabilityProveraSkaliranja");
            }
        }


       public GridsVisability()
        {
            _gridVisability = Visibility.Visible;
            _gridVisabilityPow = Visibility.Hidden;
            _gridVisabilityProveraSkaliranja = Visibility.Hidden;
        }






        public void  postaviVisability0()
        {
            _gridVisability = Visibility.Visible;
            _gridVisabilityPow = Visibility.Hidden;
            _gridVisabilityProveraSkaliranja = Visibility.Hidden;
        }


        public void postaviVisability1()
        {

            _gridVisability = Visibility.Hidden;
            _gridVisabilityPow = Visibility.Visible;
            _gridVisabilityProveraSkaliranja = Visibility.Hidden;
            SkaliranjeWindowViewModel.CheckStat.Check4 = false;
        }

        public void postaviVisability2()
        {


            _gridVisability = Visibility.Hidden;
            _gridVisabilityPow = Visibility.Hidden;
            _gridVisabilityProveraSkaliranja = Visibility.Visible;

       
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
