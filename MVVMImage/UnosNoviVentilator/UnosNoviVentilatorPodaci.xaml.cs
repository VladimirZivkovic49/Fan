using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVMImage.UnosNoviVentilator
{
    /// <summary>
    /// Interaction logic for UnosNoviVentilatorPodaci.xaml
    /// </summary>
    public partial class UnosNoviVentilatorPodaci : Window
    {
        private OpenFileDialog opp;

        public UnosNoviVentilatorPodaci()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    string pathss = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10)) + "\\Slika\\ssss.jpg";
        //    System.IO.File.Delete(pathss);

        //    opp = new OpenFileDialog();

        //    if (Convert.ToBoolean(opp.ShowDialog())==true)

        //    {
        //        //Slicka.Source = new BitmapImage(new Uri(opp.FileName));
        //        string paths = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10));//Substring(0, Environment.CurrentDirectory.IndexOf("Rada sa slikama")) + @"D:\Visual studio\C# PostKurs Vežbanja\Rada sa slikama\Rada sa slikama\Slika\";
        //        string CorrFileName = System.IO.Path.GetFileName(opp.FileName);


        //        System.IO.File.Copy(opp.FileName, paths + "\\Slika\\ssss.jpg");
        //    }

        //}
    }
}
