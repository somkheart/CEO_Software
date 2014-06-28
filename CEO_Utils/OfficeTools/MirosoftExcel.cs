using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop;
using System.IO;
using Microsoft.Office.Interop.Word;
using CEO_Devices.SmartCard;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 
namespace CEO_Utils.OfficeTools
{
    public class MirosoftExcel
    {


        public static void CreateWordProfile(CEO_SmartCard SmartCardInfo,Object oTemplatePath, Object NewFile)
        {
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlApp = new Excel.ApplicationClass();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);

            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //xlWorkSheet.Cells[1, 1] = "http://csharp.net-informations.com";

            //xlWorkBook.SaveAs("csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            //releaseObject(xlWorkSheet);
            //releaseObject(xlWorkBook);
            //releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp-Excel.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 

    }
}
