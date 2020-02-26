using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVVMImage.MainWindowModels
{
   public class UnosArhiviranihPodataka

    {


       
        private int t;
        private XmlSerializer xs;

        // svojstva kolekcija za popunu setovima podataka iz xml zapisa DataBazaRegistarZapisa/PodaciVentilatorLista.xml

        public static  ObservableCollection<UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator> listaVentilatoraPrikaz { get; set; }
        public /*static*/ ObservableCollection<UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator> podaciDataGrid { get; set; }


        // vrsi ucitavanje iz iz xml zapisa DataBazaRegistarZapisa/PodaciVentilatorLista.xml
        public void prikaziListuSacuvanahZapisa()
        {

           // inicijalizuje kolekciju

            listaVentilatoraPrikaz = new ObservableCollection<UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator>();

            

            xs = new XmlSerializer(typeof(ObservableCollection<UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator>));
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\DataBazaRegistarZapisa\\PodaciVentilatorLista.xml";

            // ispituje uslov da li postoji  xml zapis DataBazaRegistarZapisa/PodaciVentilatorLista.xml

            if ((System.IO.File.Exists(parent.Parent.FullName + "\\DataBazaRegistarZapisa\\PodaciVentilatorLista.xml")))
            {
                //ucitava setove podataka iz xml zapisa
                FileStream fss = new FileStream(path, FileMode.Open, FileAccess.Read);
                podaciDataGrid = (ObservableCollection<UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator>)xs.Deserialize(fss);

                fss.Close();

                for (t = 0; t < podaciDataGrid.Count; t++)

                {

                    UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator  pod = new  UnosNoviVentilator.UnesiNoviVentilatorModels.PodaciNoviVentilator();
                    pod.ImeVentilatoraText = podaciDataGrid[t].ImeVentilatoraText;
                    pod.TehnoloskaOznakaText = podaciDataGrid[t].TehnoloskaOznakaText;
                    pod.LokacijaUPogonuText = podaciDataGrid[t].LokacijaUPogonuText;
                    pod.ProizvodjacText = podaciDataGrid[t].ProizvodjacText;
                    //
                    listaVentilatoraPrikaz.Add(pod);
                }

            }

        }

    }
}
