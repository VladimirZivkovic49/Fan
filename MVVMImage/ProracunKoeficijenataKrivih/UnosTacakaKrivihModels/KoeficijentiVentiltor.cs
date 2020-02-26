using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{

    // popuna kolekcije  koeficijenata krivih u odnosu na broj obrtaja ventilatora 

    public class KoeficijentiVentiltor
    {
        // upis prvog clana kolekcije 
        public KoeficijentiVentiltor(ObservableCollection<Podaci> krivaPodaci)
        {
            kriveVentilator = krivaPodaci;
        }

        private static ObservableCollection<UnosTacakaKrivihModels.Podaci> kriveVentilator;

        // upis novog clana u postojecu kolekciju 
        public static ObservableCollection<UnosTacakaKrivihModels.Podaci> KriveVentilator
        {

            get { return kriveVentilator; }

            set { kriveVentilator = value; }
        }


    }
}
