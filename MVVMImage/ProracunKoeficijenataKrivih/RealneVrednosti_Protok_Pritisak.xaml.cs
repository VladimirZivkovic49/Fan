using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;

namespace MVVMImage
{
    /// <summary>
    /// Interaction logic for RealneVrednosti_Protok_Pritisak.xaml
    /// </summary>
    public partial class RealneVrednosti_Protok_Pritisak : Window
    {

        public ProracunKoeficijenataKrivih.UnosTacakaKrivihViewModel kriveViewModel;
       
             
        public RealneVrednosti_Protok_Pritisak()
        {

            kriveViewModel = new ProracunKoeficijenataKrivih.UnosTacakaKrivihViewModel();
            DataContext = kriveViewModel;
            InitializeComponent();
           

        }

     
    }

 }
   

    





