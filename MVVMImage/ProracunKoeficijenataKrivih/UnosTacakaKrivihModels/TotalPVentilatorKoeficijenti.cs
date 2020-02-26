using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{
   public class TotalPVentilatorKoeficijenti:VentilatorKriveProracunAbstact

    {
              

        public enum KoeficijentiVentilatora
        {

            TotA0,
            TotA1,
            TotA2
           
        }


        //metoda za prebrojavanje enum pozvana iz VentilatorKriveAbstract

        public override void prikaziBrojEnum()
        {

            brojEnum = Enum.GetNames(typeof(KoeficijentiVentilatora)).Count();
         

        }


        public override void upisiPrviClanListeY(int jj)
        {

            // dodeljuje tip koeficijenta kolekcije krivih za koji se vrsi proracun
            enumPoRedu = Enum.GetNames(typeof(KoeficijentiVentilatora)).ElementAt(jj).ToString();


            //vrsi dodelu u skldu sa izabranim tipom koeficijenta u svojstvo klase
            //UnosTacakaKrivihModels/Podaci

                     

            if (enumPoRedu == KoeficijentiVentilatora.TotA0.ToString())
         

            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA0;

            }
            else if (enumPoRedu == KoeficijentiVentilatora.TotA1.ToString())
           
            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA1;
            }
            else
            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA2;
            }

            //vrsi dodelu imena koefijenta u svojstvo klase
            //UnosTacakaKrivihModels/Podaci
            imeKoeficijenta = Enum.GetNames(typeof(KoeficijentiVentilatora)).ElementAt(jj).ToString();
            podaciVentList.TipKoeficijenta = imeKoeficijenta;
          
        }

        public override void upisiOstaleClanoveListeY(int jj)
        {
            // dodeljuje redni broj krive za ucitavanje 
           // var kriveBroj = KolekkcijeKoeficijenataKrivihVentilator.KriveKolekcijaKrivihVentilator[brojkrivih - 1].TipKoeficijenta;
            

            //if (kriveBroj == KoeficijentiVentilatora.TotA0.ToString())

            if (enumPoRedu == KoeficijentiVentilatora.TotA0.ToString())
            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].AA0;
            }



            else if (enumPoRedu == KoeficijentiVentilatora.TotA1.ToString())
         

            {

                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].AA1;

            }

            else
            {

                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].AA2;

            }



            imeKoeficijenta = Enum.GetNames(typeof(KoeficijentiVentilatora)).ElementAt(jj).ToString();
            podaciVentList.TipKoeficijenta = imeKoeficijenta;



        }

    }
}
