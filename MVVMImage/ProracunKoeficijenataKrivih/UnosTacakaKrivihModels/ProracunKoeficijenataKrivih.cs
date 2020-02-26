using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{
  public   class ProracunKoeficijenataKrivih:KoeficijentiProracunAbstract

    {
        ObservableCollection<Podaci> KrivaPodaci { get; set; }

        private Podaci novipodaci;

        KolekcijaKoeficijenataFamilijeKrivih kolekcijaFamilijaKrivih { get; set; }

        public override void formirajListuzaDodelu()
        {
            KrivaPodaci = new ObservableCollection<Podaci>();

            // dodeljuje vrednost rednog broja krive koja se obradjuje(ucitava)
            var brojkrive = ProtokTotalP.BrojTacaka;

            novipodaci = new Podaci();
            // dodela vrednosti i podataka krive koja se trenutno ucitava 
            novipodaci.NazivKrive = UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija[brojkrive].ImeKrive;
            novipodaci.TipKrive = ProracunRealnihVrednostiKrivih.indexKrive;
            novipodaci.ObrtajiVentilatora = UnosPodatakaZaUcitavanjeKrivih.UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel.NaziviKrivihKolekcija[brojkrive].ObrtajiVentilatora;
            novipodaci.AA0 = a0;
            novipodaci.AA1 = a1;
            novipodaci.AA2 = a2;
            novipodaci.XXProtMax = double.Parse(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XProtMax);
            novipodaci.YYPritMax = double.Parse(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPritMax);
            novipodaci.YYPowMax = double.Parse(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowMax);
            KrivaPodaci.Add(novipodaci);

            try
            {
                //upisuje prvi clan kolekcije 
                KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Add(novipodaci);

            }
            catch
            {
                // dodaje ostale clanove u kolekciju
                kolekcijaFamilijaKrivih = new KolekcijaKoeficijenataFamilijeKrivih(KrivaPodaci);

            }


        }

    }
}
