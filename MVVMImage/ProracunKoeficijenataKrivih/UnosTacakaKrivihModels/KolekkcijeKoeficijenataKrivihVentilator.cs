using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{


    //kolekcija izracunatih koeficijenata krivih u odnosu na broj ventilatora 
    //(ponasanje svakog koeficijenta svakog pojedinacnog tipa krivih)
    public class KolekkcijeKoeficijenataKrivihVentilator
    {

        //upisuje prvi clan kolekcije
        public KolekkcijeKoeficijenataKrivihVentilator(ObservableCollection<Podaci> krivaPodaci)
        {
            kriveKolekcijaKrivihVentilator = krivaPodaci;
        }

        public KolekkcijeKoeficijenataKrivihVentilator()
        {
        }


        //dodaje svaki sledeci clankolekcije
        private static ObservableCollection<UnosTacakaKrivihModels.Podaci> kriveKolekcijaKrivihVentilator;
        public static ObservableCollection<UnosTacakaKrivihModels.Podaci> KriveKolekcijaKrivihVentilator
        {

            get { return kriveKolekcijaKrivihVentilator; }

            set { kriveKolekcijaKrivihVentilator = value; }
        }

    }
}
