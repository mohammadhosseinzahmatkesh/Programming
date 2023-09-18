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
    class xlsx
    {
        public void excel()
        {
            try
            {
                Spreadsheet document = new Spreadsheet();
                Worksheet sheet = document.Workbook.Worksheets.Add("writExcelDemo");
                sheet.Cell("A1").Value = "bbb";
                sheet.Cell("B1").Value = "aaa";
                if (File.Exists(System.Environment.CurrentDirectory + "-" + "SystemInfo.xlsx"))
                {
                    File.Delete(System.Environment.CurrentDirectory + "-" + "SystemInfo.xlsx");
                }
                document.SaveAs(System.Environment.CurrentDirectory + "-" + "SystemInfo.xlsx");
                document.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


