using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{




    public class ProracunKoeficijenataVentilator : KoeficijentiProracunAbstract


    {
        //svojstvo kolekcije  
        ObservableCollection<Podaci> KrivaPodaci { get; set; }


        //polje objekta klase 
        //UnosTacakaKrivihModels/Podaci
        private Podaci novipodaci;


        //  svojstvo objekata klase UnosTacakaKrivihModels/KoeficijentiVentiltor
        KoeficijentiVentiltor koefVetilator { get; set; }

        // metoda za dodelu vrednosti u kolekciju 
        public override void formirajListuzaDodelu()
        {
         //inicijalizacija objekta
            KrivaPodaci = new ObservableCollection<Podaci>();

            //inicijalizacija  objekta 
            novipodaci = new Podaci();


            // popuna odgovarajućim izracunatim vrednostima 
            novipodaci.NazivKrive = VentilatorKriveProracunAbstact.imeKoeficijenta;
            novipodaci.TipKrive = ProracunRealnihVrednostiKrivih.indexKrive;
           
            novipodaci.AA0 = a0;
            novipodaci.AA1 = a1;
            novipodaci.AA2 = a2;
            KrivaPodaci.Add(novipodaci);

            try
            {
                // vrsi popunu izracunatim vrednostima  postojeće kolekcije u klasi 
                //UnosTacakaKrivihModels/KoeficijentiVentiltor

                KoeficijentiVentiltor.KriveVentilator.Add(novipodaci);


            }
            catch
            {
                //inicijalizuje objekat kolekcije u klasi
                //UnosTacakaKrivihModels/KoeficijentiVentiltor
                // i vrsi upis prvog clana kolekcije 
                koefVetilator = new KoeficijentiVentiltor(KrivaPodaci);

            }

        
        }

      

    }

}

