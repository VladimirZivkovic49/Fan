using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeModels
{
    public class PodaciOKrivama
    {

        public int BrojKrivihZaUcitavanjePoTipu { get; set; }
        public string ImeKrive { get; set; }
        public string ObrtajiVentilatora { get; set; }
        public int  BrojTacakaZaUcitavanjePoTipu { get; set; }
        public int IndexTipaKrive { get; set; }

    }
}
