using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

namespace MVVMImage.UnosPodatakaZaUcitavanjeKrivih
{
    /// <summary>
    /// Interaction logic for UnosPodatakaZaUcitavanje.xaml
    /// </summary>
    public partial class UnosPodatakaZaUcitavanje : Window
    {
        UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel viewModelUnosObrtaji { get; set; }

        public UnosPodatakaZaUcitavanje()
        {
            viewModelUnosObrtaji = new UnosPodatakaZaUcitavanjeVM.UnosPodatakaZaUcitavanjeViewModel();
            DataContext = viewModelUnosObrtaji;
            InitializeComponent();
        }

       
        


        private void UnesiPodatkeZaKrivu_Click(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
