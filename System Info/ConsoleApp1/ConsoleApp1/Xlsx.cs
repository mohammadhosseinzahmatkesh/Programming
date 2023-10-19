using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;
using Worksheet = Bytescout.Spreadsheet.Worksheet;
using System.Management;
using Bytescout.Spreadsheet;

namespace ConsoleApp1
{
    public class Xlsx
    {
        public void SaveExcel(List<string> Save)
        {
            try
            {
                Spreadsheet document = new Spreadsheet();
                Worksheet sheet = document.Workbook.Worksheets.Add("writExcelDemo");
                sheet.Cell("A1").Value = Save[0];
                sheet.Cell("A2").Value = Save[1];
                sheet.Cell("A3").Value = Save[2];
                sheet.Cell("A4").Value = Save[3];
                sheet.Cell("A5").Value = Save[4];
                sheet.Cell("B1").Value = Save[5];
                sheet.Cell("B2").Value = Save[6];
                sheet.Cell("B3").Value = Save[7];
                sheet.Cell("B4").Value = Save[8];
                sheet.Cell("B5").Value = Save[9];
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/" + "SystemInfo.xlsx"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"/" + "SystemInfo.xlsx");
                }
                document.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"/" + "SystemInfo.xlsx");
                document.Close();
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }
    }
}