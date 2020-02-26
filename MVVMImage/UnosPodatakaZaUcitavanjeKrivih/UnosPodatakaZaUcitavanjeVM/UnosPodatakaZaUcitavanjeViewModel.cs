using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVMImage.Commands;
using MVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeModels;

namespace MVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM
{
    public class UnosPodatakaZaUcitavanjeViewModel : INotifyPropertyChanged
    {


        public ObservableCollection<UnosPodatakaZaUcitavanjeModels.PodaciOKrivama> VentilatorObrtajiKolekcija { get; set; }
        public static ObservableCollection<UnosPodatakaZaUcitavanjeModels.PodaciOKrivama> NaziviKrivihKolekcija { get; set; }
        private UnosPodatakaZaUcitavanjeModels.PodaciOTackamaZaUnos ppodaciZaKrivu;
        private int i;
        public static string indexBrOb { get;  set; }

       



        private PodaciOKrivama podaciKrive;
        public UnosPodatakaZaUcitavanjeModels.PodaciOTackamaZaUnos PpodaciZaKrivu

        {
            get { return ppodaciZaKrivu; }
            set
            {
                ppodaciZaKrivu = value;
                OnPropertyChanged("PpodaciZaKrivu");

            }
        }

        public ParameterLessCommand selektovatiVrstuBrObrtajaCommand { get; private set; }

        public UnosPodatakaZaUcitavanjeViewModel()
        {
            VentilatorObrtajiKolekcija = new ObservableCollection<UnosPodatakaZaUcitavanjeModels.PodaciOKrivama>();
            NaziviKrivihKolekcija = new ObservableCollection<UnosPodatakaZaUcitavanjeModels.PodaciOKrivama>();


            PpodaciZaKrivu = new UnosPodatakaZaUcitavanjeModels.PodaciOTackamaZaUnos();
            selektovatiVrstuBrObrtajaCommand = new ParameterLessCommand(prikaziSelektovanuVrstuBrObrtajaClick);
          

        }

        private void prikaziSelektovanuVrstuBrObrtajaClick()
        {
            indexBrOb = PpodaciZaKrivu.BrOobrtajaSelektedIdex.ToString();
        }

        // komanda   UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Ucitaj broj obrtaja
        //za unos vrednosti broja obrtaja
        private ICommand brojObrtajaVentilatoraUnesi;
        public ICommand BrojObrtajaVentilatoraUnesi
        {
            get
            {
                if (brojObrtajaVentilatoraUnesi == null)
                {
                    brojObrtajaVentilatoraUnesi = new Commands.RelayCommand(BrojObrtajaVentilatoraUnesiExecute, BrojObrtajaVentilatoraUnesiCanExecute, false);
                }
                return brojObrtajaVentilatoraUnesi;
            }

        }

        //izvršava komandu 
        public void BrojObrtajaVentilatoraUnesiExecute(object parameter)
        {

            UnesiBrojObrtajaClick();

        }

        //postavlja uslove dostupnosti komandnog dugmeta 
        //UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Ucitaj broj obrtaja"

        public bool BrojObrtajaVentilatoraUnesiCanExecute(object parameter)
        {
            bool ObrtajiText = string.IsNullOrEmpty(PpodaciZaKrivu.BrojObrtajaVentilatoraText);
            if (ObrtajiText == true || int.Parse(PpodaciZaKrivu.BrojObrtajaVentilatoraText) == 0)
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        // komanda  //UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Unesi Podatke za krivu"
        //za unos ucitanih podataka za krive
        private ICommand podaciZaKrivuUnesi;
        public ICommand PodaciZaKrivuUnesi
        {
            get
            {
                if (podaciZaKrivuUnesi == null)
                {
                    podaciZaKrivuUnesi = new Commands.RelayCommand(PodaciZaKrivuUnesiExecute, PodaciZaKrivuUnesiCanExecute, false);
                }
                return podaciZaKrivuUnesi;
            }

        }

        //izvršava komandu 
        public void PodaciZaKrivuUnesiExecute(object parameter)
        {
            if (int.Parse(PpodaciZaKrivu.BrojTacakaZaUnosPodatakaText) > 2)
            {
                UnesiPodatkeZaKrivuClick();
            }

            else
            {
                MessageBox.Show("Broj tačaka za učitavanje mora biti veći od 2");
            }


        }

        //postavlja uslove dostupnosti komandnog dugmeta 
        //UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Unesi Podatke za krivu"

        public bool PodaciZaKrivuUnesiCanExecute(object parameter)
        {
            bool TackeUcitavanjeText = string.IsNullOrEmpty(PpodaciZaKrivu.BrojTacakaZaUnosPodatakaText);
            if (TackeUcitavanjeText == true || VentilatorObrtajiKolekcija.Count == 0)
            {
                return false;
            }

            else
            {
                return true;
            }

        }


        // metoda komande  
        //UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Unesi Podatke za krivu"

        private void UnesiBrojObrtajaClick()
        {

            UnosPodatakaZaUcitavanjeModels.PodaciOKrivama podKri = new UnosPodatakaZaUcitavanjeModels.PodaciOKrivama();
            if (VentilatorObrtajiKolekcija.Count == 0)
            {

                podKri.ObrtajiVentilatora = PpodaciZaKrivu.BrojObrtajaVentilatoraText;
                VentilatorObrtajiKolekcija.Add(podKri);

            }
            else
            {
                podKri.ObrtajiVentilatora = PpodaciZaKrivu.BrojObrtajaVentilatoraText;

                    for (j = 0; j < VentilatorObrtajiKolekcija.Count; j++)
                    {


                        if (podKri.ObrtajiVentilatora == VentilatorObrtajiKolekcija[j].ObrtajiVentilatora)
                        {
                            MessageBox.Show("Broj obrtaja je upisan");

                            reset();
                            return;

                        }

                    }

                for (k = 0; k < VentilatorObrtajiKolekcija.Count ; k++)
                {
                    if (int.Parse(podKri.ObrtajiVentilatora) < int.Parse(VentilatorObrtajiKolekcija[k].ObrtajiVentilatora))
                    {

                        VentilatorObrtajiKolekcija.Insert(k, podKri);
                        reset();
                        return;
                    }

                 }

                VentilatorObrtajiKolekcija.Add( podKri);

            }
              

            reset();
        }

        // brise vrednost texbox-a nakon izvrsenog unosa
        public void reset()
        {
            UnosPodatakaZaUcitavanjeModels.PodaciOKrivama podKri = new UnosPodatakaZaUcitavanjeModels.PodaciOKrivama();
            PpodaciZaKrivu.BrojObrtajaVentilatoraText = "";


        }


        // metoda komande  
        //UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Unesi Podatke za krivu"
        private void UnesiPodatkeZaKrivuClick()
        {

            // dodeljuje vrednost ukupnog broja tipova krivih
            var brojKrivih = VentilatorObrtajiKolekcija.Count;

            //iteracija za unos podataka u kolekciju

            for (i = 0; i < (brojKrivih); i++)
            {

                //dodeljuje podatke u svojstva klase "PodaciOKrivama"
                podaciKrive = new UnosPodatakaZaUcitavanjeModels.PodaciOKrivama();
                podaciKrive.BrojKrivihZaUcitavanjePoTipu = VentilatorObrtajiKolekcija.Count;
                podaciKrive.ObrtajiVentilatora = VentilatorObrtajiKolekcija[i].ObrtajiVentilatora;
                podaciKrive.BrojTacakaZaUcitavanjePoTipu = int.Parse(PpodaciZaKrivu.BrojTacakaZaUnosPodatakaText);
                podaciKrive.IndexTipaKrive = 1;
                
                //formira naziv krive i dodaje u svojstvo
                podaciKrive.ImeKrive = "TotalPritisak_Protok" + (i + 1).ToString();


                NaziviKrivihKolekcija.Add(podaciKrive);

            }


            //definiše startnu vrednost iteracije za novi set ucitavanja 
            var brojStat = NaziviKrivihKolekcija.Count;

            for (i = brojStat; i < (brojKrivih + brojStat); i++)
            {
                podaciKrive = new UnosPodatakaZaUcitavanjeModels.PodaciOKrivama();
                podaciKrive.BrojKrivihZaUcitavanjePoTipu = VentilatorObrtajiKolekcija.Count;
                podaciKrive.ObrtajiVentilatora = VentilatorObrtajiKolekcija[i - brojStat].ObrtajiVentilatora;
                podaciKrive.BrojTacakaZaUcitavanjePoTipu = int.Parse(PpodaciZaKrivu.BrojTacakaZaUnosPodatakaText);
                podaciKrive.IndexTipaKrive = 2;
                podaciKrive.ImeKrive = "Static_Protok" + (i - brojStat + 1).ToString();


                NaziviKrivihKolekcija.Add(podaciKrive);

            }

            //definiše startnu vrednost iteracije za novi set ucitavanja 

            var brojPow = NaziviKrivihKolekcija.Count;

            for (i = brojPow; i < (brojKrivih + brojPow); i++)
            {
                podaciKrive = new UnosPodatakaZaUcitavanjeModels.PodaciOKrivama();
                podaciKrive.BrojKrivihZaUcitavanjePoTipu = VentilatorObrtajiKolekcija.Count;
                podaciKrive.ObrtajiVentilatora = VentilatorObrtajiKolekcija[i - brojPow].ObrtajiVentilatora;
                podaciKrive.BrojTacakaZaUcitavanjePoTipu = int.Parse(PpodaciZaKrivu.BrojTacakaZaUnosPodatakaText);
                podaciKrive.IndexTipaKrive = 3;
                podaciKrive.ImeKrive = "Power_Protok" + (i - brojPow + 1).ToString();

                NaziviKrivihKolekcija.Add(podaciKrive);

            }

            // postavlja uslov za izvrsenje komandi u klasi
            // ProracunKoeficijenataKrivih.UnosTacakaKrivihViewModel

            ProracunKoeficijenataKrivih.UnosTacakaKrivihViewModel.Enabled = true;

            //otvara prozor za dalji tok izvrsenja programa 
            RealneVrednosti_Protok_Pritisak realne = new RealneVrednosti_Protok_Pritisak();

            bool dialogResult = realne.ShowDialog().Value;


        }

        private ICommand izbrisiBrojObtaja;
        private int j;
        private int k;

        public ICommand IzbrisiBrojObrtaja
        {
            get
            {
                if (izbrisiBrojObtaja == null)
                {
                    izbrisiBrojObtaja = new Commands.RelayCommand(IzbrisiBrojObrtajaExecute, IzbrisiBrojObrtajaCanExecute, false);
                }
                return izbrisiBrojObtaja;
            }

        }

       

        //izvršava komandu 
        public void IzbrisiBrojObrtajaExecute(object parameter)
        {
            VentilatorObrtajiKolekcija.RemoveAt(int.Parse(indexBrOb));
            indexBrOb = null;
        }

        //postavlja uslove dostupnosti komandnog dugmeta 
        //UnosPodatakaZaUcitavanjeKrivih/UnosPodatakaZaUcitavanje.xaml/"Unesi Podatke za krivu"

        public bool IzbrisiBrojObrtajaCanExecute(object parameter)
        {

            if (string.IsNullOrEmpty(indexBrOb) )
            {
                return false;
            }

            else
            {
                return true;
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
