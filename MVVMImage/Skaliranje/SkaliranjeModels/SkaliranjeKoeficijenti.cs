using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMImage.Skaliranje.SkaliranjeModels
{
   public  class SkaliranjeKoeficijenti
    {

        // svojstvo validacije proracuna metode "proracunajKoeficijente"
        public static bool greskaSkaliranja { get; private set; }


        // svojstva za binding vrednosti texbox-ova prozora  Skaliranje/SkaliranjeWindow.xml

        private string xNagibText;
        public string XNagibText
        {
            get { return xNagibText; }
            set
            {

                xNagibText = value;

             

            }
        }

        private string yNagibText;
        public string YNagibText
        {
            get { return yNagibText; }
            set
            {

                yNagibText = value;

     

            }
        }


        private string xOdsecakText;
        public string XOdsecakText
        {
            get { return xOdsecakText; }
            set
            {

                xOdsecakText = value;

            

            }
        }

        private string yOdsecakText;
        public string YOdsecakText
        {
            get { return yOdsecakText; }
            set
            {

                yOdsecakText = value;

         

            }
        }

        private string yPowNagibText;
        public string YPowNagibText
        {
            get { return yPowNagibText; }
            set
            {

                yPowNagibText = value;

            

            }
        }




        private string yPowOdsecakText;
        public string YPowOdsecakText
        {
            get { return yPowOdsecakText; }
            set
            {

                yPowOdsecakText = value;

             
            }
        }

      // vrsi proracun koeficijenata skaliranja osa 
        public void proracunajKoeficijente()
        {


            try
            {

                SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XNagibText = (IzracunajBkoeficijent(double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviKursor), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiKursor))).ToString();
                SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YNagibText= (IzracunajBkoeficijent(double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPrviZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YDrugiZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPrviKursor), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YDrugiKursor))).ToString();
                SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowNagibText =( IzracunajBkoeficijent(double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviKursor), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiKursor))).ToString();
                SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XOdsecakText= (IzracunajAAAkoeficijent(double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XPrviKursor), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.XDrugiKursor), double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XNagibText))).ToString();
                SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YOdsecakText= (IzracunajAAAkoeficijent(double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPrviZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YDrugiZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPrviKursor), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YDrugiKursor), double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YNagibText))).ToString();
                SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowOdsecakText =(IzracunajAAAkoeficijent(double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiZadati), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowPrviKursor), double.Parse(SkaliranjeWindowViewModel.TxBxPopunaStat.YPowDrugiKursor), double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowNagibText))).ToString();
             
                 

                // problem sa NaN vrednosti, try catch ignoriše; 
                // uveden upit da li postoji NaN i ukoliko true veštački pravi grešku za Try /Catch  ispravnu funkcionalnost
                if (double.IsNaN(double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XNagibText)) || double.IsNaN(double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YNagibText)) || double.IsNaN(double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowNagibText)) || double.IsNaN(double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.XOdsecakText)) || double.IsNaN(double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YOdsecakText) )|| double.IsNaN(double.Parse(SkaliranjeWindowViewModel.PrikazKoeficijenataStat.YPowOdsecakText)))
                {


                    greskaSkaliranja = true;
                    MessageBox.Show("Došlo je do greške tokom procesa skaliranja !! \n Ponoviti skaliranje");

                }

                else
                {
                   
                    greskaSkaliranja = false;

                }


            }
            catch
            {
                greskaSkaliranja = true;

                MessageBox.Show("Došlo je do greške tokom procesa skaliranja !! \n Ponoviti skaliranje");
                Skaliranje.SkaliranjeWindowViewModel skalVm = new Skaliranje.SkaliranjeWindowViewModel();
                skalVm.resetujSklairanje();


            }


        }


        //metoda  - model za izracunavanje koeficijenata (Nagib)
        public double IzracunajBkoeficijent(double X1, double X2, double X3, double X4)
        {


            return (2 * (X3 * X1 + X4 * X2) - (X3 + X4) * (X1 + X2)) / (2 * (X3 * X3 + X4 * X4) - ((X3 + X4) * (X3 + X4)));

        }

        //metoda  - model za izracunavanje koeficijenata (Odsecak)
        public double IzracunajAAAkoeficijent(double X1, double X2, double X3, double X4, double X5)
        {


            return ((X1 + X2) - X5 * (X3 + X4)) / 2;

        }

    }
}
