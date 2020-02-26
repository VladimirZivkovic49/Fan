using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{


    //vrsi popunu realnih vrednosti izracunatih u procesu ucitavanja krive u klasi 
    // UnosTacakaKrivihModels/ProtokTotalP

    public class PodaciKolekcija
    {

        public PodaciKolekcija()
        {
        }


        //upisuje prvi clan kolekcije 
        public PodaciKolekcija(ObservableCollection<Podaci> pPodaci)
        {
            totalPPodaci = pPodaci;
        }

       
        // upisuje novi clan u postojecu kolekciju 
        private static ObservableCollection<Podaci> totalPPodaci;
        public static ObservableCollection<Podaci> TotalPPodaci
        {
            get { return totalPPodaci; }
            set

            {
                totalPPodaci = value;
                //RaisePropertyChanged("obsFin");
            }
        }

        

    }
}
