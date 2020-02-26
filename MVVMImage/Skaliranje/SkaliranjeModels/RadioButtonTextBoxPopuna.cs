using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.Skaliranje.SkaliranjeModels
{


    // svojstva za binding vrednosti texbox-ova prozora  Skaliranje/SkaliranjeWindow.xml
    public class RadioButtonTextBoxPopuna:INotifyPropertyChanged

    {
        private string xPrviKursor;
        public string XPrviKursor
        {
            get { return xPrviKursor; }
            set
            {

                xPrviKursor = value;

                OnPropertyChanged("XPrviKursor");

            }
        }

        private string xDrugiKursor;
        public string XDrugiKursor
        {
            get { return xDrugiKursor; }
            set
            {

                xDrugiKursor = value;

                OnPropertyChanged("XDrugiKursor");

            }
        }

        private string yPrviKursor;
        public string YPrviKursor
        {
            get { return yPrviKursor; }
            set
            {

                yPrviKursor = value;

                OnPropertyChanged("YPrviKursor");

            }
        }

        private string yDrugiKursor;
        public string YDrugiKursor
        {
            get { return yDrugiKursor; }
            set
            {

                yDrugiKursor = value;

                OnPropertyChanged("YDrugiKursor");

            }
        }

        private string yPowPrviKursor;
        public string YPowPrviKursor
        {
            get { return yPowPrviKursor; }
            set
            {

                yPowPrviKursor = value;

                OnPropertyChanged("YPowPrviKursor");

            }
        }

        private string yPowDrugiKursor;
        public string YPowDrugiKursor
        {
            get { return yPowDrugiKursor; }
            set
            {

                yPowDrugiKursor = value;

                OnPropertyChanged("YPowDrugiKursor");

            }
        }


        private string xPrviZadati;
        public string XPrviZadati
        {
            get { return xPrviZadati; }
            set
            {

                xPrviZadati = value;

                OnPropertyChanged("XPrviZadati");

            }
        }

        private string xDrugiZadati;
        public string XDrugiZadati
        {
            get { return xDrugiZadati; }
            set
            {

                xDrugiZadati = value;

                OnPropertyChanged("XDrugiZadati");

            }
        }

        private string yPrviZadati;
        public string YPrviZadati
        {
            get { return yPrviZadati; }
            set
            {

                yPrviZadati = value;

                OnPropertyChanged("YPrviZadati");

            }
        }

        private string yDrugiZadati;
        public string YDrugiZadati
        {
            get { return yDrugiZadati; }
            set
            {

                yDrugiZadati = value;

                OnPropertyChanged("YDrugiZadati");

            }
        }

        private string yPowPrviZadati;
        public string YPowPrviZadati
        {
            get { return yPowPrviZadati; }
            set
            {

                yPowPrviZadati = value;

                OnPropertyChanged("YPowPrviZadati");

            }
        }

        private string yPowDrugiZadati;
        public string YPowDrugiZadati
        {
            get { return yPowDrugiZadati; }
            set
            {

                yPowDrugiZadati = value;

                OnPropertyChanged("YPowDrugiZadati");

            }
        }

        private string xProtMax;
        public string XProtMax
        {
            get { return xProtMax; }
            set
            {

                xProtMax = value;

                OnPropertyChanged("XProtMax");

            }
        }
        private string yPritMax;
        public string YPritMax
        {
            get { return yPritMax; }
            set
            {

                yPritMax = value;

                OnPropertyChanged("YPritMax");

            }
        }

        private string yPowMax;
        public string YPowMax
        {
            get { return yPowMax; }
            set
            {

                yPowMax = value;

                OnPropertyChanged("YPowMax");

            }
        }

        private string protokOsaProvera;
        public string ProtokOsaProvera
        {
            get { return protokOsaProvera; }
            set
            {

                protokOsaProvera = value;

                OnPropertyChanged("ProtokOsaProvera");

            }
        }

        private string staticPOsaProvera;
        public string StaticPOsaProvera
        {
            get { return staticPOsaProvera; }
            set
            {

                staticPOsaProvera = value;

                OnPropertyChanged("StaticPOsaProvera");

            }
        }

        private string powerOsaProvera;
        public string PowerOsaProvera
        {
            get { return powerOsaProvera; }
            set
            {

                powerOsaProvera = value;

                OnPropertyChanged("PowerOsaProvera");

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
