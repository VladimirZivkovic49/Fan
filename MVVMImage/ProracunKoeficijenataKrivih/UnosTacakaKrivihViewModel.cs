using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVMImage.Commands;
using MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels;

namespace MVVMImage.ProracunKoeficijenataKrivih
{
   public  class UnosTacakaKrivihViewModel:INotifyPropertyChanged
    {
        //polja za pridruzivanje vrednosti dobijenih u metodi "CatchMouseUnos(object objj)" u ovoj klasi
        private double currentPointX_Unos;
        private double currentPointY_Unos;

        // polje inicijalizovanog objekta klase 
        //ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/ProracunRealnihVrednostiKrivih
        
        private ProracunRealnihVrednostiKrivih proracunRv;

        
        // svojstva komandi u ovoj klasi
     
        public Commands.ParameterLessCommand resetPodatakaZaKrivuCommand { get; set; }

        

        // static svojstvo selekcije tipa krive za potrebe daljeg izvrsenja programa 
        public static UnosTacakaKrivihModels.RadioButtonsKriveSelecija kriterijumiSelekcijeStat { get; set; }


        //svojstvo za adresu slike dijagrama za binding 
        //ProracunKoeficijenataKrivih/RealneVrednosti_Protok_Pritisak.xaml/<StackPanel "LeftMoseClick"
        public string putanjaUnos { get; private set; }

        //polje za vrednost  rednog broja enum KoeficijentiVentilatora 
        //klase ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/TotalPVentilatorKoeficijenti(StaticPVentilatorKoeficijenti,PowerVentilatorKoeficijenti)
        private int jj;

        private int kolekcijaKrivih;
        //public int brojCiklusa = 1;


        private static PracenjeUcitavanja ucitavanjePracenjeStat;
        public static PracenjeUcitavanja UcitavanjePracenjeStat
        {
            get { return ucitavanjePracenjeStat; }
            set
            {
                ucitavanjePracenjeStat = value;

               ;


            }

        }

        private PracenjeUcitavanja ucitavanjePracenje;
        public PracenjeUcitavanja UcitavanjePracenje
        {
            get { return ucitavanjePracenje; }
            set
            {
                ucitavanjePracenje = value;

                OnPropertyChanged("UcitavanjePracenje");


            }

        }




        private static int brojCiklusa = 1;
        public static int BrojCiklusa
        {
            get { return brojCiklusa; }
            set { brojCiklusa = value; }


        }

        private static bool enabled;
        public static bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }


        }











        //svojstvo za pridruživanje vrednosti za binding RadioButtons
        //ProracunKoeficijenataKrivih/RealneVrednosti_Protok_Pritisak.xaml/

        private RadioButtonsKriveSelecija _kriterijumiSelekcije;
        public RadioButtonsKriveSelecija kriterijumiSelekcije

        {
            get { return _kriterijumiSelekcije; }
            set
            {
                _kriterijumiSelekcije = value;
                OnPropertyChanged("kriterijumiSelekcije");

            }
        }

        
        // konstruktor za inicijalizaciju
        public UnosTacakaKrivihViewModel()
        {

            resetPodatakaZaKrivuCommand = new Commands.ParameterLessCommand(resetujUnosPodataka);
            kriterijumiSelekcijeStat = new UnosTacakaKrivihModels.RadioButtonsKriveSelecija();
           
            //dodela adrese za binding slike dijagrama 
            putanjaUnos = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10)) + "\\Slika\\ssss.jpg";
           

            kriterijumiSelekcije = new RadioButtonsKriveSelecija();
            kriterijumiSelekcijeStat = new RadioButtonsKriveSelecija();

            UcitavanjePracenjeStat = new PracenjeUcitavanja();
            UcitavanjePracenjeStat.prikaziTrenutnKrivu();
            UcitavanjePracenje = UcitavanjePracenjeStat;

        }



        // konsruktor za dodelu vrednosti trenutne selekcije krive nakon ciklusa ucitavanja podataka 
        public UnosTacakaKrivihViewModel(RadioButtonsKriveSelecija kriterijumiSelekcijeStat1)
        {

            //UcitavanjePracenje = new PracenjeUcitavanja();
            this.kriterijumiSelekcije = kriterijumiSelekcijeStat1;

            UcitavanjePracenje = new PracenjeUcitavanja();
            UcitavanjePracenjeStat = new PracenjeUcitavanja();
            UcitavanjePracenjeStat.prikaziTrenutnKrivu();
            UcitavanjePracenje = UcitavanjePracenjeStat;


        }

        // komanda   ProracunKoeficijenataKrivih/RealneVrednosti_Protok_Pritisak.xaml/Radiobuttons 
        //za selekciju tipa krive 
        private ICommand radioButtonSelektuj;
        public ICommand RadioButtonSelektuj
        {
            get
            {
                if (radioButtonSelektuj == null)
                {
                    radioButtonSelektuj = new Commands.RelayCommand(RadioButtonSelektujExecute, RadioButtonSelektujCanExecute, false);
                }
                return radioButtonSelektuj;
            }

        }

        //izvršava komandu 
        public void RadioButtonSelektujExecute(object parameter)
        {

            selektujTipKrive();

        }

        //postavlja uslove dostupnosti "Radiobuttons" 
        public bool RadioButtonSelektujCanExecute(object parameter)
        {
            if (Enabled==false)
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        //metoda selekcije tipa krive 
        public void selektujTipKrive()
        {
            
            //upit za uslov vrsenja selekecije
            if (UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.Count!= 0 
                
                 && ((UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.ElementAt(0).BrojKrivihZaUcitavanjePoTipu))>1)
            {

                // pridružuje vrednost selektovanog tipa krive  statc svojstvu
               
                
                kriterijumiSelekcije.dodajIndex();
                kriterijumiSelekcijeStat = kriterijumiSelekcije;
                

            }
            else
            {
                MessageBox.Show("Moraju se popuniti podaci ; Broj podataka za unos mora biti veći od 1");

               kriterijumiSelekcije = new RadioButtonsKriveSelecija();
              
              //resetuje kriterijume na pocetne uslove 
               kriterijumiSelekcije.Radio_ProtokTotall = false;
               kriterijumiSelekcije.Radio_ProtokStaticl = false;
               kriterijumiSelekcije.Radio_ProtokPowerl = false;

               
            }

        }

        //komanda MouseLeftButtonDown 
        //ProracunKoeficijenataKrivih/RealneVrednosti_Protok_Pritisak.xaml/<StackPanel "LeftMoseClick"
        private ICommand _posicijaMouseUnos;
        
        public ICommand PozicijaMouseUnos
        {
            get
            {
                if (_posicijaMouseUnos == null )
                {
                    _posicijaMouseUnos = new Commands.RelayCommand(CatchMouseUnos, objj => true, false);
                }
                return _posicijaMouseUnos;
            }

        }
        // metoda komande ICommand _posicijaMouse;
        public void CatchMouseUnos(object objj)
        {
            // Dodat uslov "PodaciZaKrivu.Enabled==true" koji uslovljava pozivanje metode "fp_upisiVrednostUnos(currentPointX_Unos, currentPointY_Unos)"

           

                if (objj != null && UnosTacakaKrivihViewModel.Enabled == true)
                {


                if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_Index == int.Parse(UcitavanjePracenje.TipKrive))
                {



                    currentPointX_Unos = Mouse.GetPosition(objj as UIElement).X;

                    currentPointY_Unos = Mouse.GetPosition(objj as UIElement).Y;


                    //inicijalizacija objekata klase 
                    // ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/ProracunRealnihVrednostiKrivih

                    proracunRv = new ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.ProracunRealnihVrednostiKrivih();


                    //poziva metodu
                    proracunRv.fp_upisiVrednostUnos(currentPointX_Unos, currentPointY_Unos);

                    //}
                    UcitavanjePracenjeStat.prikaziTrenutnKrivu();
                    UcitavanjePracenje = new PracenjeUcitavanja();
                    UcitavanjePracenje = UcitavanjePracenjeStat;
                }

                else
                {
                    MessageBox.Show("Morate selektovati odgovarajuci tip krive ");

                }

            }
          
        }
        //komanda dugme "Obrada rezultata"
        //ProracunKoeficijenataKrivih/RealneVrednosti_Protok_Pritisak.xaml

        private ICommand obradiRezultate;
        public ICommand ObradiRezultate
        {
            get
            {
                if (obradiRezultate == null)
                {
                    obradiRezultate = new Commands.RelayCommand(ObradiRezultateExecute, ObradiRezultateCanExecute, false);
                }
                return obradiRezultate;
            }

        }

        //izvrsenje komande
        public void ObradiRezultateExecute(object parameter)
        {

            UnosTacakaKrivihViewModel.Enabled = true;

            //inicijalizacija objekata klasa 
            // ProracunKoeficijenataKrivih/UnosTacakaKrivihModels...

            TotalPVentilatorKoeficijenti totVe = new TotalPVentilatorKoeficijenti();
            StaticPVentilatorKoeficijenti statVe = new StaticPVentilatorKoeficijenti();
            PowerVentilatorKoeficijenti powVe = new PowerVentilatorKoeficijenti();
            ProracunKoeficijenataVentilator proVe = new ProracunKoeficijenataVentilator();


            //upit za izvrsenu selekciju 
            if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokTotall == true)
            {
                //poziva metodu u klasi
                // ProracunKoeficijenataKrivih / UnosTacakaKrivihModels/TotalPVentilatorKoeficijenti
                // za prebrojavanje članova enum KoeficijentiVentilatora

                totVe.prikaziBrojEnum();

                //iteracija za proracun koeficijenata svakog pojedinačnog člana enum KoeficijentiVentilatora
                // zavisnosi od broja obrtajaventilatora

                for (jj = 0; jj < VentilatorKriveProracunAbstact.brojEnum; jj++)
                {
                    //pozva metodu u klasi 
                    //ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/TotalPVentilatorKoeficijenti:VentilatorKriveProracunAbstact

                    totVe.formirajListuKoeficijenataZaDatiBrojObrtaja(jj);


                    //pozva metodu u klasi 
                    //ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/KoeficijentiProracunAbstract
                    proVe.izracunajKoeficijenteKrive();

                    //pozva metodu u klasi 
                    //ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/ ProracunKoeficijenataVentilator : KoeficijentiProracunAbstract

                    proVe.formirajListuzaDodelu();
                    //resetuje objekte u klasi
                    //ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/PodaciKolekcija nako izvrsenog proracuna 
                    PodaciKolekcija.TotalPPodaci = null;

                }

            }

            if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokStaticl == true)
            {
                statVe.prikaziBrojEnum();


                for (jj = 0; jj < VentilatorKriveProracunAbstact.brojEnum; jj++)
                {

                    statVe.formirajListuKoeficijenataZaDatiBrojObrtaja(jj);
                   
                    proVe.izracunajKoeficijenteKrive();
                    proVe.formirajListuzaDodelu();
                    PodaciKolekcija.TotalPPodaci = null;

                }
            }

            if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokPowerl == true)
            {
                powVe.prikaziBrojEnum();

                for (jj = 0; jj < VentilatorKriveProracunAbstact.brojEnum; jj++)
                {

                    powVe.formirajListuKoeficijenataZaDatiBrojObrtaja(jj);
                    proVe.izracunajKoeficijenteKrive();
                    proVe.formirajListuzaDodelu();
                    PodaciKolekcija.TotalPPodaci = null;

                }

                //upit sa li je dodeljena vrednost za formiranje subFoldera u folderu "DataBazaZapisa"
                 
                if (!string.IsNullOrEmpty(UnosNoviVentilator.UnesiNoviVentilatorViewModel.PodaciVentilator.TehnoloskaOznakaText))
                {
                   // inucijalizacija  objeta klase
                    UnosNoviVentilator.UnesiNoviVentilatorModels.ArhiviranjePodatakaVentilator ventKoef = new UnosNoviVentilator.UnesiNoviVentilatorModels.ArhiviranjePodatakaVentilator();

                    //// poziva metodu za skladištenje u Xml
                    //UnosNoviVentilator/UnesiNoviVentilatorModels/ArhiviranjePodatakaVentilator
                    ventKoef.unesiPodatkeNoviVentilator();

                }
            }
            //racuna ponavljanje izvrsenja komande
            brojCiklusa = brojCiklusa + 1;

            //UnosTacakaKrivihViewModel.PpodaciZaKrivuStat.BrojKrivihZaUnosText = null;

           
        }

        //upit za dostupnost komandnog dugmeta za izvvresenje 
        public bool ObradiRezultateCanExecute(object parameter)
        {

            // upit za unos broja krivih  odredjenog tipa za snimanje 
           
           int p=(UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.ElementAt(0).BrojKrivihZaUcitavanjePoTipu);
            if (p == 0)
            {
                return false;

            }
            else
            {
                //upit za odredjivanje broja obradjenih krivih

                if (KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih == null)
                {
                    kolekcijaKrivih = 0;

                }
                else
                {
                    kolekcijaKrivih = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Count;
                }

               
                //upit da li je ucitana poslednja kriva iz serije 

                if (p*brojCiklusa == kolekcijaKrivih)
                {
                    return true;
                    
                }

                else
                {
                    return false;
                }

            }
        }

        //metoda treba da se proveri

        public void resetujUnosPodataka()
        {
          
            brojCiklusa = brojCiklusa - 1;
        }


        //Komanda  treba da se proveri
        private ICommand resetujUcitanuKrivu;
       

        public ICommand ResetujUcitanuKrivu
        {
            get
            {
                if (resetujUcitanuKrivu == null)
                {
                    resetujUcitanuKrivu = new Commands.RelayCommand(ResetujUcitanuKrivuExecute, ResetujUcitanuKrivuCanExecute, false);
                }
                return resetujUcitanuKrivu;
            }

        }

       
        public void ResetujUcitanuKrivuExecute(object parameter)
        {

            resetujUnosPodataka();

         

        }

      
        public bool ResetujUcitanuKrivuCanExecute(object parameter)
        {
            if (enabled == false)
            {
                return true;
            }

            else
            {
                return false;
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
