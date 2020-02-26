using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{
    public class PowerVentilatorKoeficijenti : VentilatorKriveProracunAbstact
    {

        public enum KoeficijentiVentilatora
        {


            PowA0,
            PowA1,
            PowA2

        }

        public override void prikaziBrojEnum()
        {

            brojEnum = Enum.GetNames(typeof(KoeficijentiVentilatora)).Count();
            
        }

        public override void upisiPrviClanListeY(int jj)
        {
            enumPoRedu = Enum.GetNames(typeof(KoeficijentiVentilatora)).ElementAt(jj).ToString();
           



            if (enumPoRedu == KoeficijentiVentilatora.PowA0.ToString())


            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[pocetniBrojKrivih].AA0;

            }
            else if (enumPoRedu == KoeficijentiVentilatora.PowA1.ToString())

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


            if (kriveBroj == KoeficijentiVentilatora.PowA0.ToString())


            {
                podaciVentList.YOsaVrednost = KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[i].AA0;
            }



            else if (kriveBroj == KoeficijentiVentilatora.PowA1.ToString())


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