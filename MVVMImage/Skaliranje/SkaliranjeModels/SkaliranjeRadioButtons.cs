using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMImage
{
    public class SkaliranjeRadioButtons 
    {

        // dodela vrednosti dobijenih izvrsenjem komande "MouseLeftButtonDown" u skladu sa izabranim radioButton-om

        public void fp_upisiVrednost(double X, double Y)
        {

            var x1Zad = string.IsNullOrEmpty(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviZadati);
            var x2Zad = string.IsNullOrEmpty(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiZadati);
            var y1Zad = string.IsNullOrEmpty(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPrviZadati);
            var y2Zad = string.IsNullOrEmpty(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YDrugiZadati);
            var yPow1Zad = string.IsNullOrEmpty(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviZadati);
            var yPow2Zad = string.IsNullOrEmpty(Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiZadati);



            try
            {

                while (true)
                {


                    if (!Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check1 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check2 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check3 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check4 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check5 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check6 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check7 == true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check8== true && !Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check9 == true)
                    {

                        MessageBox.Show("Morate selektovati unos pritiskom na odgovarajuće dugme");
                        return;
                    }

                    else
                    {

                        break;


                    }


                }
                while (true)
                {


                    if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check1 == true && x1Zad == false)
                    {


                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviKursor = X.ToString();
                        break;
                    }

                    if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check2 == true && x2Zad == false)
                    {


                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiKursor = X.ToString();
                        break;

                    }

                    if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check3 == true && y1Zad == false)
                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPrviKursor = Y.ToString();
                        break;

                    }

                    if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check4 == true && y2Zad == false)

                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YDrugiKursor = Y.ToString();

                        break;

                    }

                    if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check5 == true && yPow1Zad == false)
                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviKursor = Y.ToString();
                        break;

                    }

                    if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check6 == true && yPow2Zad == false)

                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiKursor = Y.ToString();
                        break;


                    }
                   
              
                


                   else if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check7 == true)

                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.ProtokOsaProvera = (X * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XNagibText)
                                                                                         + double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XOdsecakText)).ToString("F6");

                        break;

                    }

                 else   if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check8 == true)

                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.StaticPOsaProvera = (Y * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YNagibText)
                                                                                                 + double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YOdsecakText)).ToString("F6");

                        break;

                    }

                   else if (Skaliranje.SkaliranjeWindowViewModel.CheckStat.Check9 == true)

                    {



                        Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.PowerOsaProvera = (Y * double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowNagibText)
                                                                                              + double.Parse(Skaliranje.SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowOdsecakText)).ToString("F6");

                        break;

                    }

                    else
                    {
                        MessageBox.Show("Mora biti popunjen odgovarajući Tex box");
                       return;
                        
                    }

                   
                }

                

            }


            catch
            {
                MessageBox.Show("Došlo je do greške tokom unosa podataka. Moraju biti popunjena oba TexBox-a !! \n Ponoviti skaliranje");
               



                Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviKursor = null;
                Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiKursor = null;
                Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviKursor = null;
                Skaliranje.SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiKursor = null;


            }
           
        }
   
    }

}
