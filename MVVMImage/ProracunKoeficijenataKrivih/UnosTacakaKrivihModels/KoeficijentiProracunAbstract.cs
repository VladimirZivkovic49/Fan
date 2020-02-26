using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{

    //vrsi proracun koeficijenata polinoma na osnovu unetih vrednosti 

    public abstract class KoeficijentiProracunAbstract
    {


        private int i;

        public static double a0 { get; private set; }
        public static double a1 { get; private set; }
        public static double a2 { get; private set; }


        public void izracunajKoeficijenteKrive()
        {
            a0 = 0;
            a1 = 0;
            a2 = 0;
      
            double sumX = 0;
            double sumY = 0;
            double sumX2 = 0;
            double sumX3 = 0;
            double sumX4 = 0;
            double sumX5 = 0;
            double sumX6 = 0;
            double sumXY = 0;
            double sumX2Y = 0;
            double sumX3Y = 0;



            for (i = 0; i < PodaciKolekcija.TotalPPodaci.Count(); i++)
            {

                sumX += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 1);
                sumY += Math.Pow(PodaciKolekcija.TotalPPodaci[i].YOsaVrednost, 1);
                sumX2 += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 2);
                sumX3 += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 3);
                sumX4 += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 4);
                sumX5 += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 5);
                sumX6 += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 6);
                sumXY += PodaciKolekcija.TotalPPodaci[i].XOsaVrednost * PodaciKolekcija.TotalPPodaci[i].YOsaVrednost;
                sumX2Y += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 2) * PodaciKolekcija.TotalPPodaci[i].YOsaVrednost;
                sumX3Y += Math.Pow(PodaciKolekcija.TotalPPodaci[i].XOsaVrednost, 3) * PodaciKolekcija.TotalPPodaci[i].YOsaVrednost;
            }

            double det = -(sumX2 * sumX2 * sumX2 + sumX3 * sumX3 * i + sumX4 * sumX * sumX) + (i * sumX2 * sumX4 +
                   sumX * sumX3 * sumX2 + sumX2 * sumX * sumX3);

            a0 = (-(sumX2Y * sumX2 * sumX2 + sumX3 * sumX3 * sumY + sumX4 * sumXY * sumX) + (sumY * sumX2 * sumX4 +
                       sumX * sumX3 * sumX2Y + sumX2 * sumXY * sumX3)) / det;

            a1 = (-(sumX2 * sumXY * sumX2 + sumX2Y * sumX3 * i + sumX4 * sumX * sumY) + (i * sumXY * sumX4 +
               sumY * sumX3 * sumX2 + sumX2 * sumX * sumX2Y)) / det;


            a2 = (-(sumX2 * sumX2 * sumY + sumX3 * sumXY * i + sumX2Y * sumX * sumX) + (i * sumX2 * sumX2Y +
               sumX * sumXY * sumX2 + sumY * sumX * sumX3)) / det;


            

    }

        public abstract void formirajListuzaDodelu();


    }
}
