using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{


    //kolekcija koeficijenata sva ucitane krive 

    public class KolekcijaKoeficijenataFamilijeKrivih
    {

        //upisuje prvi clan
        public KolekcijaKoeficijenataFamilijeKrivih(ObservableCollection<Podaci> krivaPodaci)
        {
            kriveKolekcijaKrivih = krivaPodaci;
        }

       // dodaje svaki sledeci clan u kolekciju

        private static ObservableCollection<UnosTacakaKrivihModels.Podaci> kriveKolekcijaKrivih;
        public static ObservableCollection<UnosTacakaKrivihModels.Podaci> KriveKolekcijaKrivih
        {

            get { return kriveKolekcijaKrivih; }

            set { kriveKolekcijaKrivih = value; }
        }


    }
}
