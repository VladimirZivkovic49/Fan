using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVVMImage.UnosNoviVentilator.UnesiNoviVentilatorModels
{
   public  class ArhiviranjePodatakaVentilator


    {


        // inicijalizuje kolekciju za popunu podataka za arhiviranje u odgovarajućem xml zapisu 
        public ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator> VentilatorPodaciList = new ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator>();


        //polja za adresiranje i upravljanje xml dokumentima
        private string nazivFoldera;
        private DirectoryInfo parent;
        private XmlSerializer xs;


        // poziva redosledom odgovarajuce metode radi popune odgovarajucih xml dokumenata
       public void unesiPodatkeNoviVentilator()
        {

            upisiRegistarZapisaLista();
            napraviFolder();
            unesikoeficijenteKrivih();
            unesikoeficijenteVentilatora();
        }



        //formira novi subFolder u folderu "DataBazaZapisa" i dodeljuje mu naziv

        // ToDo: validacija da li zapis postoji 
        // ToDo: postaviti upit Overwrite Yes/No , Ispitati mogucnost ove operacije jos prilikom unosa podataka u klasi 
        //     UnosNoviVentilator / UnesiNoviVentilatorModels /PodaciNoviVentilator
        public void napraviFolder()


        {
            //dodeljuje naziv subFoldera na osnovu svojstva popunjenog u klasi UnesiNoviVentilatorViewModel/PodaciVentilator

            nazivFoldera = UnesiNoviVentilatorViewModel.PodaciVentilator.TehnoloskaOznakaText;

            parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\DataBazaZapisa\\" + nazivFoldera;

            System.IO.Directory.CreateDirectory(path);
        }


        //formira novi   zapis "PodaciVentilatorLista.xml"  ukoliko ne postoji  u folderu "DataBazaRegistarZapisa " 
        //   odnosno dodeljuje mu podatke

        public void upisiRegistarZapisaLista()
        {

            parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\DataBazaRegistarZapisa" + "\\" + "PodaciVentilatorLista.xml";                 // "\\DataBazaIzvestaja\\";

            //provera postojanja dokumenta 
            if (!(System.IO.File.Exists(parent.Parent.FullName + "\\DataBazaRegistarZapisa" + "\\" + "PodaciVentilatorLista.xml")))

            {
                //poziva metodu za formiranje xml dokumenta i upis  seta podataka u formiran xml zapis 
                upusiuRegistarXml();

            }
            else
            {
                //poziva metodu za dodelu  postojećim  setovima zapisa u kolekciju predviđenu za popunu xml zapisa 
                
                formirajListuIzXmlIzRegistarZapisa();
                //poziva metodu upusiuRegistarXml()
                upusiuRegistarXml();


            }

        }


        // unosi set zapisa u postojeću kolekciju i formira xml zapis
        public void upusiuRegistarXml()
        {
            parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\DataBazaRegistarZapisa" + "\\" + "PodaciVentilatorLista.xml";

            VentilatorPodaciList.Add(UnesiNoviVentilatorViewModel.PodaciVentilator);
            XmlSerializer serialiser = new XmlSerializer(typeof(ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator>));

            // Create the TextWriter for the serialiser to use


            TextWriter filestream = new StreamWriter(path);

            //write to the file
            serialiser.Serialize(filestream, VentilatorPodaciList);

            // Close the file
            filestream.Close();

        }

        // upisuje setove podataka u kolekciju setova podataka iz postojećeg xml zapisa DataBazaRegistarZapisa/PodaciVentilatorLista.xml

        public void formirajListuIzXmlIzRegistarZapisa()
        {


            xs = new XmlSerializer(typeof(ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator>));
            FileStream fs = new FileStream(parent.Parent.FullName + "\\DataBazaRegistarZapisa" + "\\" + "PodaciVentilatorLista.xml", FileMode.Open, FileAccess.Read);

            VentilatorPodaciList = (ObservableCollection<UnesiNoviVentilatorModels.PodaciNoviVentilator>)xs.Deserialize(fs);
            fs.Close();

        }



        //formira  xml zapis "PodaciKoeficijentiKrivihLista.xml" i smesta ga u odgovarajuci subFolder 
        // u folderu "DataBazaZapisa"

        public void unesikoeficijenteKrivih()

        {
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\DataBazaZapisa\\" + nazivFoldera + "\\" + "PodaciKoeficijentiKrivihLista.xml";                 // "\\DataBazaIzvestaja\\";

            XmlSerializer serialiser = new XmlSerializer(typeof(ObservableCollection<ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.Podaci>));

            // Create the TextWriter for the serialiser to use


            TextWriter filestream = new StreamWriter(path);

            //write to the file

            // ucitava podatke iz kolekcije 
            // ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/KolekcijaKoeficijenataFamilijeKrivih/KriveKolekcijaKrivih

            serialiser.Serialize(filestream, ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih);

            // Close the file
            filestream.Close();

        }

        //formira  xml zapis "PodaciKoeficijentiKrivihLista.xml" i smesta ga u odgovarajuci subFolder 
        // u folderu "DataBazaZapisa"


        public void unesikoeficijenteVentilatora()

        {
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\DataBazaZapisa\\" + nazivFoldera + "\\" + "PodaciKoeficijentiVentilatorLista.xml";                 // "\\DataBazaIzvestaja\\";

            XmlSerializer serialiser = new XmlSerializer(typeof(ObservableCollection<ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.Podaci>));

            // Create the TextWriter for the serialiser to use


            TextWriter filestream = new StreamWriter(path);

            //write to the file


            // ucitava podatke iz kolekcije 
            // ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/KolekcijaKoeficijenataFamilijeKrivih/KriveVentilator

            serialiser.Serialize(filestream, ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KoeficijentiVentiltor.KriveVentilator);

            // Close the file
            filestream.Close();

        }

    }
}
