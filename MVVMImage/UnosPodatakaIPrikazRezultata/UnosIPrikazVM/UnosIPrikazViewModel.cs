using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Input;
using Microsoft.Win32;
using MVVMImage.Commands;

namespace MVVMImage.UnosPodatakaIPrikazRezultata.UnosIPrikazVM
{
   public class UnosIPrikazViewModel:INotifyPropertyChanged

    {
        private bool brojObtaja;

        private UnosIprikazModels.PodaciZaUnosIPriazMain podaciZaKrivuMain;

        public ParameterLessCommand prikazDijagramaCommand { get; private set; }

        public UnosIprikazModels.PodaciZaUnosIPriazMain PodaciZaKrivuMain

        {
            get { return podaciZaKrivuMain; }
            set
            {
                podaciZaKrivuMain = value;
                OnPropertyChanged("PodaciZaKrivuMain");

            }
        }
        private string podaciMainVm;
        public string PodaciMainVm

        {
            get { return podaciMainVm; }
            set
            {
                podaciMainVm = value;
                OnPropertyChanged("PodaciMainVm");

            }
        }

        private static UnosIprikazModels.PodaciZaUnosIPriazMain podaciZaKrivuMainSt;
        public  static UnosIprikazModels.PodaciZaUnosIPriazMain PodaciZaKrivuMainSt

        {
            get { return podaciZaKrivuMainSt; }
            set
            {
                podaciZaKrivuMainSt = value;
                

            }
        }


        public   UnosIPrikazViewModel()

        {


            prikazDijagramaCommand = new ParameterLessCommand(prikazDijagramaClick);

            PodaciZaKrivuMain = new UnosIprikazModels.PodaciZaUnosIPriazMain();
            
            PodaciZaKrivuMainSt = PodaciZaKrivuMain;
            PodaciMainVm = MainWindowModels.SelektovanjeVrsteIzTabele.selectedItem;
            
        }

        private void prikazDijagramaClick()
        {

            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            var path = parent.Parent.FullName + "\\XLSX\\" + "\\" + "PodaciKrive.xls";

            string mySheet = path;


            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbooks books = excelApp.Workbooks;
            Excel.Workbook sheet = books.Open(mySheet);


        }

        private ICommand izracunajEfikasnost;
        public ICommand IzracunajEfikasnost

        {
            get
            {
                if (izracunajEfikasnost == null)
                {
                    izracunajEfikasnost = new Commands.RelayCommand(IzracunajEfikasnostExecute, IzracunajEfikasnostCanExecute, false);
                }
                return izracunajEfikasnost;
            }

        }

       
        public void IzracunajEfikasnostExecute(object parameter)
        {
            try
            {
                KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.BrojObrtajaVentRadni = PodaciZaKrivuMain.BrojObrtajaVentilatoraText;


                KoeficijentiKrivihUOdnosuNaBrojObrtaja.ProracunKoeficijenatazaRadnibrojObrtajaVentilatora proracunEf =
                    new KoeficijentiKrivihUOdnosuNaBrojObrtaja.ProracunKoeficijenatazaRadnibrojObrtajaVentilatora();

                proracunEf.PrikazikoeficijeneBORadni();


            }
            catch
            {
               MessageBox.Show("Morajuse uneti podaci sa krivih\nTakođe proveriti dostupnost podataka u databazi");

            }
          
        }

       
        public bool IzracunajEfikasnostCanExecute(object parameter)
        {
            brojObtaja = string.IsNullOrEmpty(PodaciZaKrivuMain.BrojObrtajaVentilatoraText);

            if (brojObtaja == true)
            {
                return false;
            }

            else
            {
                return true;
            }

        }


        private ICommand izveziUExcel;
        public ICommand IzveziUExcel

        {
            get
            {
                if (izveziUExcel == null)
                {
                    izveziUExcel = new Commands.RelayCommand(IzveziUExcelExecute, IzveziUExcelCanExecute, false);
                }
                return izveziUExcel;
            }

        }

        public void IzveziUExcelExecute(object parameter)
        {

            UnosIprikazModels.IzvozPodatakaUExcel excel = new UnosIprikazModels.IzvozPodatakaUExcel();

            excel.openExcel();

            excel.addDataToExcel();

            excel.closeExcel();

            System.Windows.Forms.MessageBox.Show("Excel file created , you can find the file E:\\My_HP_Documents\\Visual studio\\VisualStudio2019\\Fan prepravka\\FanWPF - master\\MVVMImage\\XLSX\\PodaciKrive.xlsx");
            excel.showXlsx();

        }

        public bool IzveziUExcelCanExecute(object parameter)
        {
          

            if (KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.PowA2Radni==0)
            {
                return false;
            }

            else
            {
                return true;
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
