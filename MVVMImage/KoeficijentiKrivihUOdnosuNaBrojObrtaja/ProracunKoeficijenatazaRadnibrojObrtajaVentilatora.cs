using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.KoeficijentiKrivihUOdnosuNaBrojObrtaja
{
   public  class ProracunKoeficijenatazaRadnibrojObrtajaVentilatora

    {
        private int i;
       

        public enum KoeficijentiVentilatora
        {

            TotA0,
            TotA1,
            TotA2,
            StatA0,
            StatA1,
            StatA2,
            PowA0,
            PowA1,
            PowA2
        }


        // proracun koeficijenata krivih za izabrani (radni broj obrtaja) ventilatora 
        // pozivanjem metode IzracunajKoeficijenteRadneKrive
        public void PrikazikoeficijeneBORadni()
        {
            var lista = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KoeficijentiVentiltor.KriveVentilator;
            int brojOb = int.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.BrojObrtajaVentilatoraText);
           
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i].TipKrive == 1 && lista[i].NazivKrive == KoeficijentiVentilatora.TotA0.ToString())
                {

                    PodaciZaObracunIPrikazRezultata.TotalA0Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if ( lista[i].TipKrive == 1 && lista[i].NazivKrive == KoeficijentiVentilatora.TotA1.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.TotalA1Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if (lista[i].TipKrive == 1 && lista[i].NazivKrive == KoeficijentiVentilatora.TotA2.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.TotalA2Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }
                else if (lista[i].TipKrive == 2 && lista[i].NazivKrive == KoeficijentiVentilatora.StatA0.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.StatA0Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if (lista[i].TipKrive == 2 && lista[i].NazivKrive== KoeficijentiVentilatora.StatA1.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.StatA1Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if (lista[i].TipKrive == 2 && lista[i].NazivKrive == KoeficijentiVentilatora.StatA2.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.StatA2Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if (lista[i].TipKrive == 3 && lista[i].NazivKrive == KoeficijentiVentilatora.PowA0.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.PowA0Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if (lista[i].TipKrive == 3 && lista[i].NazivKrive== KoeficijentiVentilatora.PowA1.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.PowA1Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }

                else if (lista[i].TipKrive == 3 && lista[i].NazivKrive== KoeficijentiVentilatora.PowA2.ToString())
                {
                    PodaciZaObracunIPrikazRezultata.PowA2Radni = IzracunajKoeficijenteRadneKrive(brojOb, lista[i].AA0, lista[i].AA1, lista[i].AA2);

                }
                
            }

            // poziva metodu za proracun teorijskih vrednosti za za izabrani (radni broj obrtaja) ventilatora 
            IzracunajTeorijskiProtok();
        }



        public double IzracunajKoeficijenteRadneKrive(int brojOb, double A0Fam, double A1Fam, double A2Fam)
        {
           

            return Math.Pow(int.Parse(PodaciZaObracunIPrikazRezultata.BrojObrtajaVentRadni), 2) * A2Fam + int.Parse(PodaciZaObracunIPrikazRezultata.BrojObrtajaVentRadni) * A1Fam + A0Fam;

        }

      //   metoda za proracun teorijskih vrednosti za  izabrani(radni broj obrtaja) ventilatora
        public void IzracunajTeorijskiProtok()
        {
           
            double a = PodaciZaObracunIPrikazRezultata.TotalA2Radni - PodaciZaObracunIPrikazRezultata.StatA2Radni;
            double b = PodaciZaObracunIPrikazRezultata.TotalA1Radni - PodaciZaObracunIPrikazRezultata.StatA1Radni; 
            double c = PodaciZaObracunIPrikazRezultata.TotalA0Radni - PodaciZaObracunIPrikazRezultata.StatA0Radni;


            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText = ((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)).ToString();
           
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiPritisakText = (PodaciZaObracunIPrikazRezultata.TotalA2Radni * Math.Pow(double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText), 2) + double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText) * PodaciZaObracunIPrikazRezultata.TotalA1Radni + PodaciZaObracunIPrikazRezultata.TotalA0Radni).ToString("F3");
                        
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskaSnagaText= (PodaciZaObracunIPrikazRezultata.PowA2Radni * Math.Pow(double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText), 2) + double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText) * PodaciZaObracunIPrikazRezultata.PowA1Radni + PodaciZaObracunIPrikazRezultata.PowA0Radni).ToString("F3");
 
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskaEfikasnostText = ((((double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText) / 3600) * (double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiPritisakText))) / (double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskaSnagaText))) * 100).ToString("F3");
            
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzracunataEfikasnostText = ((((double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenProtokText) / 3600) * ((double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenIzlazniPritisakText) - double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenUlazniPritisakText)) / 10)) / (double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenaSnagaText)))*100).ToString("F3");
            
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.OdstupanjeIzmernogProtokaText = (double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText) - double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenProtokText)).ToString("F3");
            
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.OdstupanjeIzmernogProtokaProcenatText= (((double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText) - double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenProtokText)) / double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskiProtokText)) * 100).ToString("F3");
           
            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.OdstupanjeIzmerneSnageText = (double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskaSnagaText) - double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenaSnagaText)).ToString("F3");

            UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.OdstupanjeIzmerneSnageProcenatText = ((( double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskaSnagaText)  - double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.IzmerenaSnagaText))/ double.Parse(UnosPodatakaIPrikazRezultata.UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.TeorijskaSnagaText))*100).ToString("F3");

        }
    }
}
