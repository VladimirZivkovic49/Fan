using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{

    //svojstva za kolekcije "KoeficijentiVentiltor"i "KriveVentilator" 
    //  klase UnosTacakaKrivihModels/KoeficijentiVentiltor odnosno
    // za kolekcije "KolekcijaKoeficijenataFamilijeKrivih" i "KriveKolekcijaKrivih"
    //klase UnosTacakaKrivihModels/KolekcijaKoeficijenataFamilijeKrivih
    // za kolekcije "PPodaci"


    public class Podaci

    {
        public double XOsaVrednost{ get; set; }
        public double YOsaVrednost { get; set; }
        public string NazivKrive { get; set; }
        public string ObrtajiVentilatora { get; set; }
        public int TipKrive { get; set; }

        public double XXProtMax { get; set; }
        public double YYPritMax { get; set; }
        public double YYPowMax { get; set; }
        public double AA0 { get; set; }
        public double AA1 { get; set; }
        public double AA2 { get; set; }


        public string TipKoeficijenta { get; set; }
        
      

    }
}
