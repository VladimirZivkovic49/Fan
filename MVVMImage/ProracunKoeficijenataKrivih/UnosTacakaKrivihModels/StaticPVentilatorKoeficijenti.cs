using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{
  public   class StaticPVentilatorKoeficijenti:VentilatorKriveProracunAbstact


    {
        public enum KoeficijentiVentilatora
        {


            StatA0,
            StatA1,
            StatA2

        }

        public override void prikaziBrojEnum()
        {

            brojEnum = Enum.GetNames(typeof(KoeficijentiVentilatora)).Count();
           

        }


        public override void upisiPrviClanListeY(int jj)
        {
            enumPoRedu = Enum.GetNames(typeof(KoeficijentiVentilatora)).ElementAt(jj).ToString();
           



            if (enumPoRedu == KoeficijentiVentilatora.StatA0.ToString())
          

            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA0;

            }
            else if (enumPoRedu == KoeficijentiVentilatora.StatA1.ToString())
             
            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA1;
            }
            else
            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA2;
            }



            imeKoeficijenta = Enum.GetNames(typeof(KoeficijentiVentilatora)).ElementAt(jj).ToString();
            podaciVentList.TipKoeficijenta = imeKoeficijenta;

        }

        public override void upisiOstaleClanoveListeY(int jj)
        {
            var kriveBroj = KolekkcijeKoeficijenataKrivihVentilator.KriveKolekcijaKrivihVentilator[brojkrivih - 1].TipKoeficijenta;


            if (kriveBroj == KoeficijentiVentilatora.StatA0.ToString())


            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].AA0;
            }



            else if (kriveBroj == KoeficijentiVentilatora.StatA1.ToString())


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

