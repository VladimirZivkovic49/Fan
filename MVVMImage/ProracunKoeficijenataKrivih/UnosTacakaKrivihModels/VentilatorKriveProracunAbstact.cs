using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{


    // izracunava koeficijente krive svakog pojedinačnog tipa koeficijnta (A0,A1,A2) u odnosu na broj obrtaja ventilatora 
    // kolekcije krivih iz kolekcije  UnosTacakaKrivihModels /KolekcijaKoeficijenataFamilijeKrivih za svaki tip krive 

    public abstract class VentilatorKriveProracunAbstact

    {
               
        public static int brojEnum { get; set; }

        // inicijalizacija objekta kolekcije 
        public ObservableCollection<Podaci> PPodaci = new ObservableCollection<Podaci>();

        public KolekkcijeKoeficijenataKrivihVentilator kolekcijaFamilijaKrivihVentilator { get; set; }

        public int  pocetniBrojKrivih { get; set; }

        public int brojkrivih { get; set; }

        public Podaci podaciVentList { get; set; }

        
        public static string imeKoeficijenta { get; set; }

        public string enumPoRedu { get; set; }

        PodaciKolekcija kolekcija { get; set; }

        public int i { get; private set; }

        //vrsi brojanje clanova enum KoeficijentiVentilatora   klasa
        //UnosTacakaKrivihModels/TotalPVentilatorKoeficijenti;UnosTacakaKrivihModels/StaticPVentilatorKoeficijenti
        // UnosTacakaKrivihModels/PowerVentilatorKoeficijenti

        public abstract void prikaziBrojEnum();



        public void formirajListuKoeficijenataZaDatiBrojObrtaja(int jj)


        {
            podaciVentList = new Podaci();
            //inicijalizuje objekat kolekcije 
            PPodaci = new ObservableCollection<Podaci>();

           
            // resetuje kolekciju 
            KolekkcijeKoeficijenataKrivihVentilator.KriveKolekcijaKrivihVentilator = null;

            //resetuje vrednost broja krivih
            brojkrivih = 0;

            // postavlja vrednost za pocetni broj krivih
            pocetniBrojKrivih = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Count-(UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.ElementAt(0).BrojKrivihZaUcitavanjePoTipu)+brojkrivih;

            // resetuje svojstvo  PodaciKolekcija kolekcija
            kolekcija = null;

            //poziva metodu za upis prvog clana kolekcije X i Y komponente tacke tacke unosa 
            podaciVentList.TipKrive = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].TipKrive;
            upisiPrviClanListeX(jj);

            //iteracija za upis ostalih clanova kolekcije 
            for (i = pocetniBrojKrivih; i < KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Count; i++)
            {
                // definise redni broj clana za upis 
                var kriveBroj = KolekkcijeKoeficijenataKrivihVentilator.KriveKolekcijaKrivihVentilator[brojkrivih - 1].TipKoeficijenta;

                // inicijalizuje klasu sa svojstvima potrebim za priduživanje novih izracunatih vrednosti
                podaciVentList = new Podaci();

                //dodeljuje Tip krive 
                podaciVentList.TipKrive = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].TipKrive;

                //dodeljuje vrednost  broja obrtaja ventilatora kao X komponentu tačke unosa za ostale tacke unosa 
                podaciVentList.XOsaVrednost = double.Parse(KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].ObrtajiVentilatora);

                // poziva metodu za upis ostalih vrednosti  Y komponente tacke unosa 
                upisiOstaleClanoveListeY(jj);

                // dodeljuje podatke u kolekciju "PPpodaci"
                PPodaci.Add(podaciVentList);



                try
                {
                    kolekcija = new PodaciKolekcija(PPodaci);

                }
                catch
                {

                    kolekcijaFamilijaKrivihVentilator = new KolekkcijeKoeficijenataKrivihVentilator(PPodaci);

                }

            }
            
        }

        //metoda za upis prvog clana kolekcije  Xkomponenta tacke
        private void upisiPrviClanListeX(int jj)
        {

            podaciVentList = new Podaci();
            podaciVentList.TipKrive = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].TipKrive;
            podaciVentList.XOsaVrednost = double.Parse(KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].ObrtajiVentilatora);

            //poziva metodu za upis prvog clana kolekcije ykomponenta tacke
            upisiPrviClanListeY(jj);

            PPodaci.Add(podaciVentList);
            kolekcijaFamilijaKrivihVentilator = new KolekkcijeKoeficijenataKrivihVentilator(PPodaci);
            brojkrivih = KolekkcijeKoeficijenataKrivihVentilator.KriveKolekcijaKrivihVentilator.Count;
            pocetniBrojKrivih = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Count - (UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija.ElementAt(0).BrojKrivihZaUcitavanjePoTipu) + brojkrivih;

        }

        //metoda za upis prvog clana kolekcije ykomponenta tacke
        public abstract void upisiPrviClanListeY(int jj);
        //metoda za upis ostalih clanova kolekcije ykomponenta tacke
        public abstract void upisiOstaleClanoveListeY(int jj);

    }

}  
