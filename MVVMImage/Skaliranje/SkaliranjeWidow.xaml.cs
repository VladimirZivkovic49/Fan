using System;
using System.Collections.Generic;
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

namespace MVVMImage.Skaliranje
{
    /// <summary>
    /// Interaction logic for SkaliranjeWidow.xaml
    /// </summary>
    public partial class SkaliranjeWidow : Window
    {

        Skaliranje.SkaliranjeWindowViewModel skalWindowViewModel { get; set; }

       

        public SkaliranjeWidow()
        {

            skalWindowViewModel = new SkaliranjeWindowViewModel();
            DataContext = skalWindowViewModel;


            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //UnosTacakaProtokPritisak obj = new UnosTacakaProtokPritisak();
            //UserControlContainer.Children.Add(obj);

        }
    }
}
