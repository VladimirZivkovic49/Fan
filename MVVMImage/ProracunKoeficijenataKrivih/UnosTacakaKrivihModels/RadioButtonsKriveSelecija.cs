using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{


    // svojstva za binding vrednosti RadioButtons prozora  Skaliranje/SkaliranjeWindow.xml

    public class RadioButtonsKriveSelecija:INotifyPropertyChanged
    {

     

        private  bool radio_ProtokTotall;
        private bool radio_ProtokStaticl;
        private  bool radio_ProtokPowerl;
        private int  radio_Index;



        public  bool Radio_ProtokTotall
        {
            get { return radio_ProtokTotall; }
            set
            {
                radio_ProtokTotall = value;
                OnPropertyChanged("Radio_ProtokTotall");
            }
        }

        public  bool Radio_ProtokStaticl
        {
            get { return radio_ProtokStaticl; }
            set
            {
                radio_ProtokStaticl= value;
                OnPropertyChanged("Radio_ProtokStaticl");
            }
        }


        public  bool Radio_ProtokPowerl
        {
            get { return radio_ProtokPowerl; }
            set
            {
                radio_ProtokPowerl = value;
                OnPropertyChanged("Radio_ProtokPowerl");
            }
        }

        public int Radio_Index
        {
            get { return radio_Index; }
            set
            {
                radio_Index = value;
                OnPropertyChanged("Radio_Index");
            }
        }


        public void dodajIndex()
        {
            if (radio_ProtokTotall == true)
            {

                radio_Index = 1;

            }

           else if(radio_ProtokStaticl == true)
            {
                radio_Index = 2;

            }


            else if (radio_ProtokPowerl == true)
            {
                radio_Index = 3;

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
