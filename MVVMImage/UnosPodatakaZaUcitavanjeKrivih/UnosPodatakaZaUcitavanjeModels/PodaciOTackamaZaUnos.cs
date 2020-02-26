using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeModels
{
   public  class PodaciOTackamaZaUnos:INotifyPropertyChanged

    {

        private string imeKriveText;
        public string ImeKriveText
        {
            get { return imeKriveText; }
            set
            {
                imeKriveText = value;


                OnPropertyChanged("ImeKriveText");


            }

        }

        private string brojObrtajaVentilatoraText;
        public string BrojObrtajaVentilatoraText
        {
            get { return brojObrtajaVentilatoraText; }
            set
            {
                brojObrtajaVentilatoraText = value;
                OnPropertyChanged("BrojObrtajaVentilatoraText");

            }

        }

        private string brojTacakaZaUnosPodatakaText;
        public string BrojTacakaZaUnosPodatakaText
        {
            get { return brojTacakaZaUnosPodatakaText; }
            set
            {
                brojTacakaZaUnosPodatakaText = value;
                OnPropertyChanged("BrojTacakaZaUnosPodatakaText");

            }

        }
        private int brOobrtajaSelektedIdex;
        public int BrOobrtajaSelektedIdex
        {
            get { return brOobrtajaSelektedIdex; }
            set
            {
                brOobrtajaSelektedIdex = value;
                OnPropertyChanged("BrOobrtajaSelektedIdex");

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
