using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using myExcel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Drawing;

namespace MyLib
{
    public class Excel_Operations
    {
        const string ExcelKey = "Excel.Application";
       public myExcel.Application excel = null;
       public myExcel.Workbook newWorkbook;
     public    myExcel.Worksheet firstWorksheet;
      public   myExcel.Worksheet zweitesWorksheet;
        
        #region Excel Open
        public void Open_New_Page()
        {
            try
            {
                excel = (myExcel.Application)Marshal.GetActiveObject(ExcelKey);
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("The Excel Application läuft nicht im Hintergrund. \n Es wird jetzt gestartet", "Excel Application");
                try
                {
                    excel = new myExcel.ApplicationClass();
                    //Oder So
                    //Type excelType = System.Type.GetTypeFromProgID(ExcelKey);
                    //excel = (myExcel.Application)System.Activator.CreateInstance(excelType);
                }
                catch (Exception)
                {
                    MessageBox.Show("Excel_Start fehlgeschlagen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            newWorkbook = excel.Workbooks.Add();
            firstWorksheet = (myExcel.Worksheet)newWorkbook.Worksheets[1];
            zweitesWorksheet = (myExcel.Worksheet)newWorkbook.Worksheets.Add();
            zweitesWorksheet.Name = "Daten";
            firstWorksheet.Name = "Quelldatei_ Daten Eintragung";
            
            excel.Visible = true;

        }
        #endregion

        #region Excel papier ausfüllen
      public virtual void Blatt_ausfuellen(string pfad_Dll_Datei = null,Icon[] large_Icon = null, Icon[] small_Icon = null,string [] pfad_icons = null)
        {
            firstWorksheet.Cells[1, 1] = "SSSSSSSSSS";
            firstWorksheet.Cells[1, 1] = "Pfad der Quelldatei";
            firstWorksheet.Cells[1, 2] = ":";
            firstWorksheet.Cells[1, 3] = pfad_Dll_Datei;
            ((myExcel.Range)firstWorksheet.Cells[1, 1]).Columns.AutoFit();
            firstWorksheet.Cells[3, 1] = " Azahl der Icons";
            firstWorksheet.Cells[3, 2] = ":";
            firstWorksheet.Cells[3, 3] = large_Icon.Length;
            ((myExcel.Range)firstWorksheet.Cells[3, 1]).Columns.AutoFit();
            zweitesWorksheet.Cells[1, 1] = "Index";
            zweitesWorksheet.Cells[1, 2] = "Pfad";
            zweitesWorksheet.Cells[1, 3] = "Größe";
            ((myExcel.Range)zweitesWorksheet.Cells[1, 1]).Columns.AutoFit();
            ((myExcel.Range)zweitesWorksheet.Cells[1, 2]).Columns.AutoFit();
            ((myExcel.Range)zweitesWorksheet.Cells[1, 3]).Columns.AutoFit();
            for (int i = 0; i < large_Icon.Length; i++)
            {
                zweitesWorksheet.Cells[i+2,  1] = i;
                zweitesWorksheet.Cells[i+2, 2] = pfad_Dll_Datei + @"\Icon_of_Index"+i+".jpg";
                ((myExcel.Range)zweitesWorksheet.Cells[i+2, 2]).Columns.AutoFit();
                ((myExcel.Range)zweitesWorksheet.Cells[i+2, 1]).Columns.AutoFit();
                zweitesWorksheet.Cells[i + 2, 3] = large_Icon[i].Size.ToString();

            }
        }
        
        #endregion
      
    }
}
