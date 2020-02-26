using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

// vlado izgleda da napreduješ
// git novi komentar 27.10.2018
namespace MVVMImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        MainVindowViewModel viewModel { get; set; }

        public MainWindow()
        {

            viewModel = new MainVindowViewModel();
            DataContext = viewModel;
            InitializeComponent();
           
        }

       
    }
}



  
        


