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
                sheet.Cell("B1").Value = Save[2];
                sheet.Cell("B2").Value = Save[3];
                sheet.Cell("C1").Value = Save[4];
                sheet.Cell("C2").Value = Save[5] + "MHz";
                sheet.Cell("D1").Value = Save[6];
                sheet.Cell("D2").Value = Save[7];
                sheet.Cell("E1").Value = Save[8];
                sheet.Cell("E2").Value = Save[9] + "MHz"; 
                sheet.Cell("F1").Value = Save[10];
                sheet.Cell("F2").Value = Save[11];
                sheet.Cell("G1").Value = Save[12];
                sheet.Cell("G2").Value = Save[13] + "GB" + Save[14]+ "GB";
                sheet.Cell("H1").Value = Save[15];
                sheet.Cell("H2").Value = Save[16];

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