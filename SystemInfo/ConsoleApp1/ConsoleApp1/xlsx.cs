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
        public void excel(string A1, string B1, string C1, string D1, string E1)
        {
            try
            {
                Spreadsheet document = new Spreadsheet();
                Worksheet sheet = document.Workbook.Worksheets.Add("writExcelDemo");
                sheet.Cell("A1").Value = A1;
                sheet.Cell("B1").Value = B1;
                sheet.Cell("C1").Value = C1;
                sheet.Cell("D1").Value = D1;
                sheet.Cell("E1").Value = E1;
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/" + "SystemInfo.xlsx"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"/" + "SystemInfo.xlsx");
                }
                document.SaveAs(AppDomain.CurrentDomain.BaseDirectory + @"/" + "SystemInfo.xlsx");
                document.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


