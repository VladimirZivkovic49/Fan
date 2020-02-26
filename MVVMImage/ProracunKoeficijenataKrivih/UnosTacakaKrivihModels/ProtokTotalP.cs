using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{


    //formira kolekciju ucitanih vrednosti sa dijagrama 
    //ProracunKoeficijenataKrivih /RealneVrednosti_Protok_Pritisak.xaml/ StackPanel "LeftMoseClick"
    // izabranog tipa krive

    public class ProtokTotalP


    {
        //svojstvo klase
        // ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/PodaciKolekcija
        PodaciKolekcija kolekcija { get; set; }

        private Podaci podaciObsList;
       
        public static int redniBrojUcitavanja { get; set; }

        public static int BrojTacaka { get; private set; }


        //inicijalizacija objekta kolekcije 
        public ObservableCollection<Podaci> PPodaci = new ObservableCollection<Podaci>();

        internal void ucitajTacke(int trenutniBrojUcitavanja)
        {

                redniBrojUcitavanja = trenutniBrojUcitavanja;

               //inicijalizacija objekta kolekcije 
                podaciObsList = new Podaci();
            
               // pridruzuje ucitane vrednosti svojstvima i formira kolekciju 
                //podaciObsList.NazivKrive = UnosTacakaKrivihViewModel.PpodaciZaKrivuStat.ImeKriveText;
                //podaciObsList.ObrtajiVentilatora = UnosTacakaKrivihViewModel.PpodaciZaKrivuStat.BrojObrtajaVentilatoraText;
                podaciObsList.XOsaVrednost = ProracunRealnihVrednostiKrivih.totalP_Protok;
                podaciObsList.YOsaVrednost = ProracunRealnihVrednostiKrivih.totalP_Pritisak;
                PPodaci.Add(podaciObsList);


            //upit za formiranje nove kolekcije u klasi odnosno doddavanje vrednosti u postojeći objekat 
            // ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/PodaciKolekcija

            if (redniBrojUcitavanja == 0)
                {

                kolekcija = new PodaciKolekcija(PPodaci);


            }
                else
                {
                    PodaciKolekcija.TotalPPodaci.Add(podaciObsList);

                }

            // registruje redni broj ucitavanja
            redniBrojUcitavanja = redniBrojUcitavanja + 1;

            //upit o broju izvrsenih ucitavanja

            if (redniBrojUcitavanja < UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.ElementAt(0).BrojTacakaZaUcitavanjePoTipu)
            {
                // vraća na poziv metode 
                // (metoda u ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/ProracunRealnihVrednostiKrivih)

                return;

            }
            else
            {
               
                //resetuje na pocetno stanje za novi unos i 
                //poziva metode za proracun na osnovu unesenih vrednosti 

              



                ProracunKoeficijenataKrivih proKo = new ProracunKoeficijenataKrivih();

                //poziva metodu za proracun koeficijenata krivih  u klasi 
                //  ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/ProracunKoeficijenataKrivih

                proKo.izracunajKoeficijenteKrive();
                proKo.formirajListuzaDodelu();

                MessageBox.Show("Kraj učitavanja");




                BrojTacaka = BrojTacaka + 1;

              


               

                int p = (UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.ElementAt(0).BrojKrivihZaUcitavanjePoTipu);

                if (p * UnosTacakaKrivihViewModel.BrojCiklusa == KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Count)
                {

                    UnosTacakaKrivihViewModel.Enabled = false;
                }

                else
                {
                    UnosTacakaKrivihViewModel.Enabled = true;
                }


                redniBrojUcitavanja = 0;

                //UnosTacakaKrivihViewModel.Enabled = false;
                UnosTacakaKrivihViewModel unvm = new UnosTacakaKrivihViewModel(UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat);

              


            }

            //prikaziTrenutnKrivu();

           }
       
    }
    }
