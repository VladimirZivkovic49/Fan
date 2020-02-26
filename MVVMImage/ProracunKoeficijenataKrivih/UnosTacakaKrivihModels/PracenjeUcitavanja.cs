using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{
     public class PracenjeUcitavanja:INotifyPropertyChanged


    {

        private string imeKriveZaUcitavanje;
        public string ImeKriveZaUcitavanje
        {
            get { return imeKriveZaUcitavanje; }
            set
            {
                imeKriveZaUcitavanje=value;
                OnPropertyChanged("ImeKriveZaUcitavanje");




            }
        }


        private string brojObrtajaKriveZaUcitavanje;
        public string BrojObrtajaKriveZaUcitavanje
        {
            get { return brojObrtajaKriveZaUcitavanje; }
            set
            {
                brojObrtajaKriveZaUcitavanje = value;
                OnPropertyChanged("BrojObrtajaKriveZaUcitavanje");




            }
        }

        private string redniBrojTackeUcitavanja;
        public string RedniBrojTackeUcitavanja
        {
            get { return redniBrojTackeUcitavanja; }
            set
            {
                redniBrojTackeUcitavanja = value;
                OnPropertyChanged("RedniBrojTackeUcitavanja");


            }
        }

        private string tipKrive;
        public string TipKrive
        {
            get { return tipKrive; }
            set
            {
                tipKrive = value;
                OnPropertyChanged("TipKrive");


            }
        }



        public void prikaziTrenutnKrivu()
        {
            if (ProtokTotalP.BrojTacaka < UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.Count)
            {

                imeKriveZaUcitavanje = UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija[ProtokTotalP.BrojTacaka].ImeKrive;
                brojObrtajaKriveZaUcitavanje = UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija[ProtokTotalP.BrojTacaka].ObrtajiVentilatora;
                redniBrojTackeUcitavanja = (ProtokTotalP.redniBrojUcitavanja + 1).ToString();
                tipKrive = (UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija[ProtokTotalP.BrojTacaka].IndexTipaKrive).ToString(); 

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
