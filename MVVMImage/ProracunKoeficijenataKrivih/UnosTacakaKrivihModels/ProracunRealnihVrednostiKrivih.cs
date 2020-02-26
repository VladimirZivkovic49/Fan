using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMImage.ProracunKoeficijenataKrivih.UnosTacakaKrivihModels
{
    public class ProracunRealnihVrednostiKrivih
    {

        // svojstva podataka tacke krive koja se ucitava sa 
        //  ProracunKoeficijenataKrivih /RealneVrednosti_Protok_Pritisak.xaml/ StackPanel "LeftMoseClick"


        public static double totalP_Protok { get; private set; }
        public  static double totalP_Pritisak { get; private set; }
        public static int rb { get; set; }
        public static int indexKrive { get; private set; }


        // metoda - proracun ucitanih vrednosti sa dijagrama u 
        //ProracunKoeficijenataKrivih /RealneVrednosti_Protok_Pritisak.xaml/ StackPanel "LeftMoseClick"

        internal void fp_upisiVrednostUnos(double currentPointX_Unos, double currentPointY_Unos)
        {

            // dodela rednog broja krive koja se ucitava

            rb = ProtokTotalP.redniBrojUcitavanja;

            // upit validnosti selektovanja tipa krive koja se ucitava sa prozora 
            //ProracunKoeficijenataKrivih /RealneVrednosti_Protok_Pritisak.xaml

            if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokTotall == false && UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokStaticl == false
                && UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokPowerl == false)
            {
                MessageBox.Show("Morate selektovati krivu na odgovarajuće dugme");
                return;

            }

            else
            {
                //upit izvrsene selekcije tipa krive koja se ucitava sa prozora 
                //i proracun realnih vrednosti na osnovu ucitavanja

                if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokTotall == true|| UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokStaticl == true)

                {

               totalP_Protok = currentPointX_Unos * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XNagibText)+ double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XOdsecakText);
               totalP_Pritisak = currentPointY_Unos * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YNagibText) + double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YOdsecakText);

                    //dodela tipa krive na osnovu izvrsene selekcije

                    if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokTotall == true)
                    {
                        indexKrive = UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_Index;
                    }
                    else
                    {
                        indexKrive = UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_Index;
                    }


                }

                if (UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_ProtokPowerl == true)

                {

                      totalP_Protok = currentPointX_Unos * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XNagibText)+ double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XOdsecakText);
                      totalP_Pritisak = currentPointY_Unos * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowNagibText) + double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowOdsecakText);

                      indexKrive = UnosTacakaKrivihViewModel.kriterijumiSelekcijeStat.Radio_Index;


                }

                //inicijalizacija objekta klase ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/ ProtokTotalP
                ProtokTotalP tot = new ProtokTotalP();

                //poziva metodu za dodelu ucitanih vrednosti ove klase u kolekciju
                tot.ucitajTacke(rb);


            }

          }

        }
    }
