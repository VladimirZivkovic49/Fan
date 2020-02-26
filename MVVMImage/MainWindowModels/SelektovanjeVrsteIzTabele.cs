using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVVMImage.MainWindowModels
{
    public class SelektovanjeVrsteIzTabele 

    {

        //polja za adresiranje i upravljanje xml dokumentima

        private string nazivFoldera;
        private DirectoryInfo parent;
        private XmlSerializer xs;

        //svojstvo selektovane vrste( verovatno se može uprostiti i eliministi)

        public static string selectedItem { get; set; }


        //  svojstvo za index vrste u datagrid  "ventilatoriDataGrid"/ MainWindow.xaml, 

        private static int _docSelectedIndexSel;
        public static int DocSelectedIndexSel
        {
            get { return _docSelectedIndexSel; }
            set
            {
                _docSelectedIndexSel = value;
          
            }
        }

        //svojstvo za pozivanje podataka izabranog ventilatora iz databaze (predstavlja ime subfoldera podataka datog ventilatora)
        // u databazi "DataBazaZapisa"(folder)

        private static string tehnoloskaOznakaTag;
        public static string TehnoloskaOznakaTag
        {

            get { return tehnoloskaOznakaTag; }
            set { tehnoloskaOznakaTag = value; }

        }


        // metoda za izvrsenje i dodelu selekcije 
        //verovatno se moze uprostiti
        //probati dodati parametar "_docSelectedIndexText " iz MainVindowViewModel clase 

        public void selektujTag()
        {

            if (MainWindowModels.UnosArhiviranihPodataka.listaVentilatoraPrikaz.Count != 0)

            {

               TehnoloskaOznakaTag = null;
                
                selectedItem = MainWindowModels.UnosArhiviranihPodataka.listaVentilatoraPrikaz[_docSelectedIndexSel].TehnoloskaOznakaText;

                TehnoloskaOznakaTag = selectedItem;
              
            }
        }


        //metoda za ucitavanje arhiviranih podataka selektovanog ventilatora (podaci koeficijenata krivih)
        public void ucitajKolekcijuKoeficijenataKrivih()

        {
            nazivFoldera = selectedItem;
            parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            xs = new XmlSerializer(typeof(ObservableCollection<ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.Podaci>));
            FileStream fs = new FileStream(parent.Parent.FullName + "\\DataBazaZapisa\\" + nazivFoldera + "\\PodaciKoeficijentiKrivihLista.xml", FileMode.Open, FileAccess.Read);


            // popuna kolekcije  u ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/KolekcijaKoeficijenataFamilijeKrivih/KriveKolekcijaKrivih
            // odgovarajučim podacima selektovanog ventilatora
            ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih = (ObservableCollection<ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.Podaci>)xs.Deserialize(fs);
            fs.Close();


        }

        //metoda za ucitavanje arhiviranih podataka selektovanog ventilatora (podaci koeficijenata ventilatora)

        public void ucitajKolekcijuKoeficijenataKrivihVentilator()
        {
            nazivFoldera = selectedItem;
            parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            xs = new XmlSerializer(typeof(ObservableCollection<ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.Podaci>));
            FileStream fs = new FileStream(parent.Parent.FullName + "\\DataBazaZapisa\\" + nazivFoldera + "\\PodaciKoeficijentiVentilatorLista.xml", FileMode.Open, FileAccess.Read);


            // popuna kolekcije  u  ProracunKoeficijenataKrivih/UnosTacakaKrivihModels/KoeficijentiVentiltor/KriveVentilator
            // odgovarajučim podacima selektovanog ventilatora

            ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KoeficijentiVentiltor.KriveVentilator = (ObservableCollection<ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.Podaci>)xs.Deserialize(fs);
            fs.Close();

            //Otvara prozor  UnosPodatakaIPrikazRezultata/UlazniIIzlazniPodaci.xaml nakon zavrsenog unosa podataka 

            UnosPodatakaIPrikazRezultata.UlazniIIzlazniPodaci ulIzPod = new UnosPodatakaIPrikazRezultata.UlazniIIzlazniPodaci();

            bool dialogResult = ulIzPod.ShowDialog().Value;

        }

    }
}
