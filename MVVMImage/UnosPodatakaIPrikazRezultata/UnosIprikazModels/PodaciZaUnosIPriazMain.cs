using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.UnosPodatakaIPrikazRezultata.UnosIprikazModels
{
   public class PodaciZaUnosIPriazMain:INotifyPropertyChanged


    {
        private string brojObrtajaVentilatoraText;
        public string BrojObrtajaVentilatoraText
        {
            get { return brojObrtajaVentilatoraText; }
            set
            {
                brojObrtajaVentilatoraText = value;
                OnPropertyChanged("BrojObrtajaVentilatoraText")

                ;
            }

        }

       
        private string teorijskiProtokText;
        public string TeorijskiProtokText
        {
            get { return teorijskiProtokText; }
            set
            {
                teorijskiProtokText = value;
                OnPropertyChanged("TeorijskiProtokText")

                ;
            }

        }

        private string teorijskaSnagaText;
        public string TeorijskaSnagaText
        {
            get { return teorijskaSnagaText; }
            set
            {
                teorijskaSnagaText = value;
                OnPropertyChanged("TeorijskaSnagaText")

                ;
            }

        }

        private string teorijskaEfikasnostText;
        public string TeorijskaEfikasnostText
        {
            get { return teorijskaEfikasnostText; }
            set
            {
                teorijskaEfikasnostText = value;
                OnPropertyChanged("TeorijskaEfikasnostText")

                ;
            }

        }

        private string izracunataEfikasnostText;
        public string IzracunataEfikasnostText
        {
            get { return izracunataEfikasnostText; }
            set
            {
                izracunataEfikasnostText = value;
                OnPropertyChanged("IzracunataEfikasnostText")

                ;
            }

        }

        private string teorijskiPritisakText;
        public string TeorijskiPritisakText
        {
            get { return teorijskiPritisakText; }
            set
            {
                teorijskiPritisakText = value;
                OnPropertyChanged("TeorijskiPritisakText")

                ;
            }

        }
        private string izmerenProtokText;
        public string IzmerenProtokText
        {
            get { return izmerenProtokText; }
            set
            {
                izmerenProtokText = value;
                OnPropertyChanged("IzmerenProtokText")

                ;
            }

        }

        private string izmerenaSnagaText;
        public string IzmerenaSnagaText
        {
            get { return izmerenaSnagaText; }
            set
            {
                izmerenaSnagaText = value;
                OnPropertyChanged("IzmerenaSnagaText")

                ;
            }

        }

        private string izmerenUlazniPritisakText;
        public string IzmerenUlazniPritisakText
        {
            get { return izmerenUlazniPritisakText; }
            set
            {
                izmerenUlazniPritisakText = value;
                OnPropertyChanged("IzmerenUlazniPritisakText")

                ;
            }

        }

        private string izmerenIzlazniPritisakText;
        public string IzmerenIzlazniPritisakText
        {
            get { return izmerenIzlazniPritisakText; }
            set
            {
                izmerenIzlazniPritisakText = value;
                OnPropertyChanged("IzmerenIzlazniPritisakText")

                ;
            }

        }
        private string odstupanjeIzmernogProtokaText;
        public string OdstupanjeIzmernogProtokaText
        {
            get { return odstupanjeIzmernogProtokaText; }
            set
            {
                odstupanjeIzmernogProtokaText = value;
                OnPropertyChanged("OdstupanjeIzmernogProtokaText")

                ;
            }

        }
        private string odstupanjeIzmernogProtokaProcenatText;
        public string OdstupanjeIzmernogProtokaProcenatText
        {
            get { return odstupanjeIzmernogProtokaProcenatText; }
            set
            {
                odstupanjeIzmernogProtokaProcenatText = value;
                OnPropertyChanged("OdstupanjeIzmernogProtokaProcenatText")

                ;
            }

        }

        private string odstupanjeIzmerneSnageText;
        public string OdstupanjeIzmerneSnageText
        {
            get { return odstupanjeIzmerneSnageText; }
            set
            {
                odstupanjeIzmerneSnageText = value;
                OnPropertyChanged("OdstupanjeIzmerneSnageText")

                ;
            }

        }


        private string odstupanjeIzmerneSnageProcenatText;
        public string OdstupanjeIzmerneSnageProcenatText
        {
            get { return odstupanjeIzmerneSnageProcenatText; }
            set
            {
                odstupanjeIzmerneSnageProcenatText = value;
                OnPropertyChanged("OdstupanjeIzmerneSnageProcenatText")

                ;
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
