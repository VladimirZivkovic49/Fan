using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MVVMImage.Commands;

namespace MVVMImage.UnosNoviVentilator
{
    public class UnesiNoviVentilatorViewModel:INotifyPropertyChanged

    {
        public ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator> VentilatorPodaciList = new ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator>();
    

        private string nazivFoldera;
        private DirectoryInfo parent;
        private XmlSerializer xs;
        public ParameterLessCommand unesiPodatkeNoviVentilatorCommand { get; private set; }
        public ParameterLessCommand izmeniSlikuCommand { get; private set; }



        // svojstvo unesenih podataka  iz texbox-ova prozora UnosNoviVentilatorPodaci.xaml( binding texbox Text)
        private UnesiNoviVentilatorModels.PodaciNoviVentilator podaciVentilatorText;
        public UnesiNoviVentilatorModels.PodaciNoviVentilator PodaciVentilatorText
      
        {
            get { return podaciVentilatorText; }
            set
            {
                podaciVentilatorText = value;
                OnPropertyChanged("PodaciVentilatorText");

            
            }

        }
        //  static svojstvo unesenih podataka  iz texbox-ova prozora UnosNoviVentilatorPodaci.xaml( binding texbox Text)
        // za potrebe koriscenja ovih podataka u narednim izvrsenjima programa 
        private static UnesiNoviVentilatorModels.PodaciNoviVentilator podaciVentilator;
        public static  UnesiNoviVentilatorModels.PodaciNoviVentilator PodaciVentilator


        {
            get { return podaciVentilator; }
            set
            {
                podaciVentilator = value;
                //;
            }

        }
        // konstruktor za inicijalizaciju objekata
        public UnesiNoviVentilatorViewModel()
        {

            unesiPodatkeNoviVentilatorCommand = new Commands.ParameterLessCommand(unesiPodatkeNoviVentilatorClick);
            izmeniSlikuCommand = new Commands.ParameterLessCommand(izmeniSlikuClick);

            PodaciVentilatorText = new UnesiNoviVentilatorModels.PodaciNoviVentilator();

            // dodela podataka u static svojstvo 
            PodaciVentilator = PodaciVentilatorText;
    
        }

        // komanda dugme  "Izmeni Sliku" / UnosNoviVentilatorPodaci.xaml", za uvoz odgovarajuće
        //slike dijagrama ventilatora

        private void izmeniSlikuClick()
        {

            OpenFileDialog opp = new OpenFileDialog();

            if (Convert.ToBoolean(opp.ShowDialog()) == true)
            {
               
                string paths = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10));//Substring(0, Environment.CurrentDirectory.IndexOf("Rada sa slikama")) + @"D:\Visual studio\C# PostKurs Vežbanja\Rada sa slikama\Rada sa slikama\Slika\";
                string CorrFileName = System.IO.Path.GetFileName(opp.FileName);


                try
                {
                    
                    System.IO.File.Copy(opp.FileName, paths + "\\Slika\\ssss.jpg");
                }

                catch
                {

                    // obezbedjuje program od unosa pogresnog formata (uvoz proizvoljong tipa dokumenta van strukture programa)
                    string pathss = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10)) + "\\Slika\\ssss.jpg";
                    System.IO.File.Delete(pathss);
                    MessageBox.Show("Došlo je do greške prilikom učitavanja slike; Ponovi učitavanje");

                }
            }
        }

        // komanda dugme  "Napravi Novi Zapis" / UnosNoviVentilatorPodaci.xaml", 

       //  validacija valjanog unosa svih potrebnih podataka i dopustanje izvrsenja sledcih koraka programa 

       // propusteno :TREBA validovati sve unose u texboxove !!!!!!!!!!

        private void unesiPodatkeNoviVentilatorClick()
        {

            string paths = Environment.CurrentDirectory.Substring(0, (Environment.CurrentDirectory.Length - 10));

            if (!(System.IO.File.Exists(paths + "\\Slika\\ssss.jpg")))
            {
                
                MessageBox.Show(" Morate uvesti sliku dijagrama datog ventilatora");
          
            }
            else
            {
                //otvara prozor  Skaliranje/SkaliranjeWidow.xaml za dalji tok izvrsenja programa 
                Skaliranje.SkaliranjeWidow skalWin = new Skaliranje.SkaliranjeWidow();

                bool dialogResult = skalWin.ShowDialog().Value;

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
