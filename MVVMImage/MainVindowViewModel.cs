using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Xml.Serialization;
using MVVMImage.Commands;
using MVVMImage.UnosNoviVentilator.UnesiNoviVentilatorModels;

namespace MVVMImage
{
    public class MainVindowViewModel:INotifyPropertyChanged
    {



        //Svojstva za komande
        public ParameterLessCommand otvoriWindowNoviVentilatorCommand { get; private set; }
        public ParameterLessCommand prikaziListuSacuvanahZapisaCommand { get; private set; }
        public ParameterLessCommand selektovatiVrstuCommand { get; private set; }



        //  svojstvo za index vrste u datagrid  "ventilatoriDataGrid"/ MainWindow.xaml, 
        //prilikom  izvrsenja selekcije "SelectedIndex="{Binding DocSelectedIndex}"

        private int _docSelectedIndex;
        public int DocSelectedIndex
        {
            get { return _docSelectedIndex; }
            set
            {

                _docSelectedIndex = value;
                RaisePropertyChanged("DocSelectedIndex");

            }
        }

        //svojstvo liste za prikaz liste sačuvanih xml zapisa arhive ucitanih podataka (ventilatora)
        //  iz "DataBazaRegistarZapisa/PodaciVentilatorLista.xml"

        private ObservableCollection<PodaciNoviVentilator> listaVentilatoraPrikazDataGrid ;
        public ObservableCollection<PodaciNoviVentilator> ListaVentilatoraPrikazDataGrid
        {
            get { return listaVentilatoraPrikazDataGrid; }
            set
            {
                listaVentilatoraPrikazDataGrid = value;
                OnPropertyChanged("ListaVentilatoraPrikazDataGrid");

            }
        }

        // konstruktor za inicijalizaciju objekata 

        public MainVindowViewModel()
        {

            otvoriWindowNoviVentilatorCommand = new ParameterLessCommand(otvoriWindowNoviVentilatorClick);

            prikaziListuSacuvanahZapisaCommand = new ParameterLessCommand(prikaziListuSacuvanahZapisaClick);

            selektovatiVrstuCommand = new ParameterLessCommand(prikaziSelektovanuVrstuClick);

            ListaVentilatoraPrikazDataGrid = new ObservableCollection<PodaciNoviVentilator>();
                      
        }

        // komanda dugme za otvaranje prozora "UnosNoviVentilator/ UnosNoviVentilatorPodaci.xaml"
        public void otvoriWindowNoviVentilatorClick()
        {

            //brise postijecu sliku ventilatora u folderu "Slika"
            // osigurava unos slike ventilatora i uslovaljava izvrsenje komande na dugme "Napravi Novi Zapis" prozora
            //"UnosNoviVentilator/ UnosNoviVentilatorPodaci.xaml"

            string pathss = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10)) + "\\Slika\\ssss.jpg";
            System.IO.File.Delete(pathss);

            // otvara prozor  "UnosNoviVentilator/ UnosNoviVentilatorPodaci.xaml"
            UnosNoviVentilator.UnosNoviVentilatorPodaci unosNovivent = new UnosNoviVentilator.UnosNoviVentilatorPodaci();
            bool dialogResult = unosNovivent.ShowDialog().Value;
        }



        // komanda dugme  "Tabela i unos iz XML" / MainWindow.xaml", za ucitavanje podataka u dataGrid 

        private void prikaziListuSacuvanahZapisaClick()
        {
            //pozivanje metode "prikaziListuSacuvanahZapisa" iz  MainWindowModels/UnosArhiviranihPodataka
            MainWindowModels.UnosArhiviranihPodataka unArh = new MainWindowModels.UnosArhiviranihPodataka();
            unArh.prikaziListuSacuvanahZapisa();

            //popuna sa podacima za prikaz na datagrid
            ListaVentilatoraPrikazDataGrid = new ObservableCollection<PodaciNoviVentilator>();
            ListaVentilatoraPrikazDataGrid = MainWindowModels.UnosArhiviranihPodataka.listaVentilatoraPrikaz;

        }

        //  komanda LeftMouseDownClick dodeljuje index selektovane vrste i poziva metode  u 
        //  MainWindowModels/SelektovanjeVrsteIzTabele za popunu sacuvanih podataka iz databaze 
        
        private void prikaziSelektovanuVrstuClick()
        {
            MainWindowModels.SelektovanjeVrsteIzTabele selVrs = new MainWindowModels.SelektovanjeVrsteIzTabele();
            MainWindowModels.SelektovanjeVrsteIzTabele.DocSelectedIndexSel = DocSelectedIndex;

            selVrs.selektujTag();
            selVrs.ucitajKolekcijuKoeficijenataKrivih();
            selVrs.ucitajKolekcijuKoeficijenataKrivihVentilator();

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

