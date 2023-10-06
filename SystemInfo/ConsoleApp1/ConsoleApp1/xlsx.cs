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
     public class xlsx
    {
        public void excel(string A1, string A2, string A3, string A4, string A5, string B1, string B2, string B3, string B4, string B5)
        {
            try
            {
                Spreadsheet document = new Spreadsheet();
                Worksheet sheet = document.Workbook.Worksheets.Add("writExcelDemo");
                sheet.Cell("A1").Value = A1;
                sheet.Cell("A2").Value = A2;
                sheet.Cell("A3").Value = A3;
                sheet.Cell("A4").Value = A4;
                sheet.Cell("A5").Value = A5;
                sheet.Cell("B1").Value = B1;
                sheet.Cell("B2").Value = B2;
                sheet.Cell("B3").Value = B3;
                sheet.Cell("B4").Value = B4;
                sheet.Cell("B5").Value = B5;
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


