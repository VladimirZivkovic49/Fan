using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MVVMImage.UnosPodatakaIPrikazRezultata.UnosIprikazModels
{
   public class IzvozPodatakaUExcel
    {

        private DirectoryInfo parent;

        private string excelFilePath = string.Empty;
        public string ExcelFilePath
        {
            get { return excelFilePath; }
            set { excelFilePath = value; }
        }

        Microsoft.Office.Interop.Excel.Application myExcelApplication;
        Microsoft.Office.Interop.Excel.Workbook myExcelWorkbook;
        Microsoft.Office.Interop.Excel.Worksheet myExcelWorkSheet;

        private int i;
        private int k;


        public void openExcel()
        {
            myExcelApplication = null;

            myExcelApplication = new Microsoft.Office.Interop.Excel.Application(); // create Excell App
            myExcelApplication.DisplayAlerts = false; // turn off alerts
            parent = System.IO.Directory.GetParent(Environment.CurrentDirectory);
            ExcelFilePath = parent.Parent.FullName + "\\XLSX" + "\\" + "PodaciKrive.xls";

            myExcelWorkbook = (Microsoft.Office.Interop.Excel.Workbook)(myExcelApplication.Workbooks._Open(excelFilePath, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value)); // open the existing excel file

            int numberOfWorkbooks = myExcelApplication.Workbooks.Count; // get number of workbooks (optional)

            myExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            myExcelWorkSheet.Name = "WorkSheet 1"; // define a name for the worksheet (optinal)

            int numberOfSheets = myExcelWorkbook.Worksheets.Count; // get number of worksheets (optional)
        }

        public void addDataToExcel(/*string firstname, string lastname, string language, string email, string company*/)
        {



            myExcelWorkSheet.Cells[1, 1] = "Koeficijenti Krivih";

            myExcelWorkSheet.Cells[2, 1] = "Broj Obrtaja";
            myExcelWorkSheet.Cells[2, 2] = "AA0";
            myExcelWorkSheet.Cells[2, 3] = "AA1";
            myExcelWorkSheet.Cells[2, 4] = "AA2";
            myExcelWorkSheet.Cells[2, 5] = "Tip krive";

            for (i = 0; i < ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih.Count; i++)
            {


                myExcelWorkSheet.Cells[i + 3, 1] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[k].ObrtajiVentilatora;
                myExcelWorkSheet.Cells[i + 3, 2] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[k].AA0;
                myExcelWorkSheet.Cells[i + 3, 3] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[k].AA1;
                myExcelWorkSheet.Cells[i + 3, 4] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[k].AA2;
                myExcelWorkSheet.Cells[i + 3, 5] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[k].TipKrive;
                k = k + 1;


            }
            myExcelWorkSheet.Cells[13, 1] = "Radni broj obrtaja";
            myExcelWorkSheet.Cells[13, 3] = UnosIPrikazVM.UnosIPrikazViewModel.PodaciZaKrivuMainSt.BrojObrtajaVentilatoraText;
            myExcelWorkSheet.Cells[14, 1] = "Koeficijenti radnakriva";
            myExcelWorkSheet.Cells[15, 1] = "Tip krive";
            myExcelWorkSheet.Cells[15, 2] = "AA0";
            myExcelWorkSheet.Cells[15, 3] = "AA1";
            myExcelWorkSheet.Cells[15, 4] = "AA2";
            myExcelWorkSheet.Cells[16, 1] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[0].TipKrive; ;
            myExcelWorkSheet.Cells[16, 2] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.TotalA0Radni;
            myExcelWorkSheet.Cells[16, 3] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.TotalA1Radni;
            myExcelWorkSheet.Cells[16, 4] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.TotalA2Radni;
            myExcelWorkSheet.Cells[17, 1] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[3].TipKrive; ;
            myExcelWorkSheet.Cells[17, 2] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.StatA0Radni;
            myExcelWorkSheet.Cells[17, 3] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.StatA1Radni;
            myExcelWorkSheet.Cells[17, 4] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.StatA2Radni;
            myExcelWorkSheet.Cells[18, 1] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[6].TipKrive; ;
            myExcelWorkSheet.Cells[18, 2] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.PowA0Radni;
            myExcelWorkSheet.Cells[18, 3] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.PowA1Radni;
            myExcelWorkSheet.Cells[18, 4] = KoeficijentiKrivihUOdnosuNaBrojObrtaja.PodaciZaObracunIPrikazRezultata.PowA2Radni;
            myExcelWorkSheet.Cells[20, 1] = "Ypritisak osa Max";
            myExcelWorkSheet.Cells[21, 1] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[0].YYPritMax; ;
            myExcelWorkSheet.Cells[20, 2] = "Ypower osa Max";
            myExcelWorkSheet.Cells[21, 2] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[0].YYPowMax; ;
            myExcelWorkSheet.Cells[20, 3] = "Xprotok osa Max";
            myExcelWorkSheet.Cells[21, 3] = ProracunKoeficijenataKrivih.UnosTacakaKrivihModels.KolekcijaKoeficijenataFamilijeKrivih.KriveKolekcijaKrivih[0].XXProtMax; ;





            /* rowNumber = rowNumber+2;*/  // if you put this method inside a loop, you should increase rownumber by one or wat ever is your logic

        }

        public void closeExcel()
        {
            try
            {
                myExcelWorkbook.SaveAs(excelFilePath, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value); // Save data in excel


                myExcelWorkbook.Close(true, excelFilePath, System.Reflection.Missing.Value); // close the worksheet


            }
            finally
            {
                if (myExcelApplication != null)
                {
                    myExcelApplication.Quit(); // close the excel application
                }
            }

        }
        public void showXlsx()
        {

        }

    }
}
