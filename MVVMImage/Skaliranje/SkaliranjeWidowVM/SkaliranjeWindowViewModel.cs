using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVMImage.Commands;

namespace MVVMImage.Skaliranje
{
   public class SkaliranjeWindowViewModel:INotifyPropertyChanged
    {

        //polja za dodelu vrednosti metode CatchMouse(object obj)

        private double currentPointX;
        private double currentPointY;

        //svojstvo za  binding SklaliranjeWindow/StackPanel x:Name="stpn_Dijagram"/Image  x:Name="Slicka "
        public string putanja { get; private set; }

        // polje inicijalizacije objekta  SkaliranjeModels/SkaliranjeRadioButtons
        private SkaliranjeRadioButtons skalbutt;

        //svojstva za inicijalizaciju objekata komanddi
        public Commands.ParameterLessCommand radioButtonClickCommand { get; set; }
        public ParameterLessCommand skalirajCommand { get; private set; }

        //svojstva za dodelu vrednosti klase SkaliranjeModels/RadioCheckSkaliranje
        public Skaliranje.SkaliranjeModels.RadioCheckSkaliranje Check { get; set; }

        // static svojstva za dodelu vrednosti 
        public static Skaliranje.SkaliranjeModels.RadioCheckSkaliranje CheckStat { get; set; }


        // static svojstva za dodelu vrednosti klase SkaliranjeModels/RadioButtonTextBoxPopuna za potrebe daljeg košcenja
        // ovih vrednosti tokom izvrsenja programa
        public static Skaliranje.SkaliranjeModels.RadioButtonTextBoxPopuna TxBxPopunaStat { get; set; }


        //svojstva za dodelu vrednosti klase SSkaliranjeModels/RadioButtonTextBoxPopuna
        private Skaliranje.SkaliranjeModels.RadioButtonTextBoxPopuna txBxPopuna;
        public Skaliranje.SkaliranjeModels.RadioButtonTextBoxPopuna TxBxPopuna
        {
            get { return txBxPopuna; }
            set
            {
                txBxPopuna = value;
                OnPropertyChanged("TxBxPopuna");

            }

        }

        //svojstvo za dodelu vrednosti za binding SkaliranjeWindow/Grid x:Name="UserControlContainerPotok"

        private static SkaliranjeModels.GridsVisability _visabilityStat;
        public static SkaliranjeModels.GridsVisability visabilityStat
        {
            get { return _visabilityStat; }
            set
            {
                _visabilityStat = value;
               
            }
        }


        private SkaliranjeModels.GridsVisability _visability;
        public SkaliranjeModels.GridsVisability visability
        {
            get { return _visability; }
            set
            {
                _visability = value;
                OnPropertyChanged("visability");
            }
        }


        public ParameterLessCommand ZatvoriSkaliranjeCommand { get; private set; }


        public static Skaliranje.SkaliranjeModels.SkaliranjeKoeficijenti PrikazKoeficijenataStat { get; set; }


        //svojstvo za dodelu vrednosti klase SkaliranjeModels/SkaliranjeKoeficijenti
        private Skaliranje.SkaliranjeModels.SkaliranjeKoeficijenti prikazKoeficijenata;
        public Skaliranje.SkaliranjeModels.SkaliranjeKoeficijenti PrikazKoeficijenata

        {
            get { return prikazKoeficijenata; }
            set
            {
                prikazKoeficijenata = value;
                OnPropertyChanged("PrikazKoeficijenata");

            }
        }


       
        //public SkaliranjeWindowViewModel skal { get; set; }

        //inicijalizacija objekata

        public SkaliranjeWindowViewModel()
        {

            putanja = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10)) + "\\Slika\\ssss.jpg";

            radioButtonClickCommand = new Commands.ParameterLessCommand(radioButtonClick);
            skalirajCommand = new Commands.ParameterLessCommand(skalirajButtonCklick);

            Check = new Skaliranje.SkaliranjeModels.RadioCheckSkaliranje();
            TxBxPopuna = new Skaliranje.SkaliranjeModels.RadioButtonTextBoxPopuna();
            TxBxPopunaStat = new SkaliranjeModels.RadioButtonTextBoxPopuna();

            PrikazKoeficijenata = new SkaliranjeModels.SkaliranjeKoeficijenti();
            PrikazKoeficijenataStat = new SkaliranjeModels.SkaliranjeKoeficijenti();
            visabilityStat = new SkaliranjeModels.GridsVisability();
            visability = new SkaliranjeModels.GridsVisability();
            visability = visabilityStat;
            ZatvoriSkaliranjeCommand = new ParameterLessCommand(zatvoriSkaliranjeClick);
        }

       

        // dodeljuje vrednosti u svojstva CheckStat probati premestiti u drugu komandu

        public void radioButtonClick()
        {
           
            CheckStat = Check;

        }


        //komanda MouseLeftButtonDown ;SklairanjeWindow/StackPanel x:Name="stpn_Dijagram"

        private ICommand _posicijaMouse;
        public ICommand PozicijaMouse
        {
            get
            {
                if (_posicijaMouse == null)
                {
                    _posicijaMouse = new Commands.RelayCommand(CatchMouse, obj => true, false);
                }
                return _posicijaMouse;
            }

        }

        // metoda komande ICommand _posicijaMouse;
        public void CatchMouse(object obj)
        {
            if (obj != null)
            {
                currentPointX = Mouse.GetPosition(obj as UIElement).X;

                currentPointY = Mouse.GetPosition(obj as UIElement).Y;

                // dodela vrednosti u svojstvo TxBxPopunaStat

                TxBxPopunaStat = TxBxPopuna;
                
                skalbutt = new SkaliranjeRadioButtons();


                //pozivanje metode SkaliranjeModels/SkaliranjeRadioButtons/fp_upisiVrednost
                skalbutt.fp_upisiVrednost(currentPointX, currentPointY);

                
                if (!string.IsNullOrEmpty(TxBxPopunaStat.YDrugiKursor) && (Check.Check7==false && Check.Check8==false && Check.Check9==false))
                {
                    //pozivanje metode
                    visabilityStat = new SkaliranjeModels.GridsVisability();
                 
                    visabilityStat.postaviVisability1();
                    visability = visabilityStat;

                }
              
            }

        }

        // komanda dugme  "Skaliraj" / SklairanjeWindow.xaml" za izracunavanje koeficijenata skaliranja osa
        public void skalirajButtonCklick()
        {
            // upit za validizaciju pravilnog unosa podataka 

            if (string.IsNullOrEmpty(TxBxPopunaStat.XProtMax) && string.IsNullOrEmpty(TxBxPopunaStat.YPritMax) && string.IsNullOrEmpty(TxBxPopunaStat.YPowMax))
            {
                MessageBox.Show(" Moraju se popuniti sve stavke; Proveri unos podataka. ");

            }
            else
            {


                //inicijalizacija objekta klase SkaliranjeModels/SkaliranjeKoeficijenti 
                SkaliranjeModels.SkaliranjeKoeficijenti skalKoef = new Skaliranje.SkaliranjeModels.SkaliranjeKoeficijenti();


                // pozivanje metodu
                skalKoef.proracunajKoeficijente();

                PrikazKoeficijenata = PrikazKoeficijenataStat;
                



                //// upit o valjanosti izvrsenog skaliranja i otvaranje 
                ////prozora ProracunKoeficijenataKrivih/RealneVrednosti_Protok_Pritisak za dalji tok izvrsenja programa 

                //if (Skaliranje.SkaliranjeModels.SkaliranjeKoeficijenti.greskaSkaliranja == false)
                //{



                //}
                //// uspostavlja  zateceno stanje tokom upisa vrednosti za skaliranje u slucaju pojave greske tokom procesa skaliranja

            }
        }
        private ICommand prikaziProveruSkaliranja;
        public ICommand PrikaziProveruSkaliranja
        {
            get
            {
                if (prikaziProveruSkaliranja == null)
                {
                    prikaziProveruSkaliranja = new Commands.RelayCommand(PrikaziProveruSkaliranjaExecute, PrikaziProveruSkaliranjaCanExecute, false);
                }
                return prikaziProveruSkaliranja;
            }

        }

        //izvršava komandu 
        public void PrikaziProveruSkaliranjaExecute(object parameter)
        {
            visabilityStat = new SkaliranjeModels.GridsVisability();
            visabilityStat.postaviVisability2();
            visability = visabilityStat;

            Check.Check6 = false;
            CheckStat.Check6 = false;



        }

        public bool PrikaziProveruSkaliranjaCanExecute(object parameter)
        {
            bool skaliranjeIzvrseno = string.IsNullOrEmpty(PrikazKoeficijenataStat.YPowOdsecakText);
            if (skaliranjeIzvrseno == true )
            {
                return false;
            }

            else
            {
                return true;
            }

        }
        private void zatvoriSkaliranjeClick()
        {
           if(MessageBox.Show("Skaliranje OK?", "Selektuj", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {


                UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanje ucNk = new UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanje();

                bool dialogResult = ucNk.ShowDialog().Value;

            }

            else
            {
                resetujSklairanje();

            }

           
        }
        public void resetujSklairanje()
        {

            visabilityStat = new SkaliranjeModels.GridsVisability();
            visabilityStat.postaviVisability0();
            visability = visabilityStat;
            Check.Check6 = false;
            CheckStat.Check6 = false;
            Check.Check7 = false;
            CheckStat.Check7 = false;
            Check.Check8 = false;
            CheckStat.Check8 = false;
            Check.Check9 = false;
            CheckStat.Check9 = false;



            TxBxPopuna = new Skaliranje.SkaliranjeModels.RadioButtonTextBoxPopuna();
            TxBxPopunaStat = new SkaliranjeModels.RadioButtonTextBoxPopuna();

            PrikazKoeficijenata = new SkaliranjeModels.SkaliranjeKoeficijenti();
            PrikazKoeficijenataStat = new SkaliranjeModels.SkaliranjeKoeficijenti();



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
