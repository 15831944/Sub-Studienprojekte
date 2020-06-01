using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using System.Drawing;
using Microsoft.Office.Interop.Excel;

namespace IteratorWorker
{
    public class Worker : Excel_Operations
    {
        public Worker()
        {

        }


        int i = 2;
        public virtual void work(FileInfo file)
        {
            Debug.Print(file.FullName);

            MyLib.IconExtract new_Extract = new IconExtract(file.FullName);
            ausfuellen(file, i);
            i++;



          




            //Icons holen und speichern
            //Ergebnisse in Excel speichern
        }
        void ausfuellen(FileInfo File,int j)
        {
            zweitesWorksheet.Name = "Daten";
            firstWorksheet.Name = "Blablabla";
            zweitesWorksheet.Cells[1, 1] = "Datei Name";
            
            zweitesWorksheet.Cells[1, 2] = "Größe";
           
            zweitesWorksheet.Cells[1, 3] = "Übergeordneter Ordner";
          
            zweitesWorksheet.Cells[1, 4] = "Pfad";
          
            zweitesWorksheet.Cells[j, 1] = File.Name;
            
            zweitesWorksheet.Cells[j, 2] = File.Length + " Byte";
           
            zweitesWorksheet.Cells[j, 3] = File.DirectoryName;
          
            zweitesWorksheet.Cells[j, 4] = File.FullName;
           





        }




        public void init()
        {
            base.Open_New_Page();
            //Start Excel
        }

        public void finish()
        {
            ((Range)zweitesWorksheet.Range[zweitesWorksheet.Cells[1, 1], zweitesWorksheet.Cells[i, 4]]).Columns.AutoFit();
/*            ((Range)zweitesWorksheet.Cells[1, 1]).Columns.AutoFit();
            ((Range)zweitesWorksheet.Cells[1, 2]).Columns.AutoFit();
            ((Range)zweitesWorksheet.Cells[1, 3]).Columns.AutoFit();
            ((Range)zweitesWorksheet.Cells[1, 4]).Columns.AutoFit();
  */       
            //save Excel and quit
        }
    }
}
