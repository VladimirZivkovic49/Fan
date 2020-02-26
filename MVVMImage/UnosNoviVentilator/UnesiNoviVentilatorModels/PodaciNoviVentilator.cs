using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMImage.UnosNoviVentilator.UnesiNoviVentilatorModels
{
   public  class PodaciNoviVentilator:INotifyPropertyChanged

    // svojstva za dodelu podataka iz textbox-ova  prozora  UnosNoviVentilator /  UnosNoviVentilatorPodaci.xaml
    {
        private string imeVentilatoraText;
        public string ImeVentilatoraText
        {
            get { return imeVentilatoraText; }
            set
          {
                imeVentilatoraText = value;
                OnPropertyChanged("ImeVentilatoraText");

          }

        }

        private string tehnoloskaOznakaText;
        public string TehnoloskaOznakaText
        {
            get { return tehnoloskaOznakaText; }
            set
            {
                tehnoloskaOznakaText = value;
                OnPropertyChanged("TehnoloskaOznakaText");

            }

        }

        private string lokacijaUPogonuText;
        public string LokacijaUPogonuText
        {
            get { return lokacijaUPogonuText; }
            set
            {
                lokacijaUPogonuText = value;
                OnPropertyChanged("LokacijaUPogonuText");

            }

        }

        private string proizvodjacText;
        public string ProizvodjacText
        {
            get { return proizvodjacText; }
            set
            {
                proizvodjacText = value;
                OnPropertyChanged("ProizvodjacText");

            }

        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void RaisePropertyChanged(
             [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(caller));

            }

        }



    }
}
