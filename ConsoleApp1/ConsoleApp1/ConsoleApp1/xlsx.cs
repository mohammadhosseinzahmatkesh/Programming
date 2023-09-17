using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class xlsx
    {
       public void main()
       {
         string Name = System.Environment.CurrentDirectory +"-"+"SystemInfo.xlsx";
         SpreadsheetDocument SpreadsheetDocument = SpreadsheetDocument.Create(Name, SpreadsheetDocumentType.Workbook);

         WorkbookPart workbookPart = SpreadsheetDocument.AddWorkbookPart();
         workbookPart.Workbook = new Workbook();

         workbookPart.Workbook.AppendChild(new Sheets());

         WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
         worksheetPart.Worksheet = new Worksheet(new SheetData());

         Sheet sheet = new Sheet
         {
           Id = workbookPart.GetIdOfPart(worksheetPart),
           SheetId = 1,
           Name = "TestSheet",
         };
         SpreadsheetDocument.WorkbookPart.Workbook.Sheets.Append(sheet);

         Row row = new Row();

         SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
         sheetData.Append(row);

         Cell cell = new Cell
         {
           CellReference = "A1",
           CellValue = new CellValue("Hello Excel"),
           DataType = CellValues.String
         };
         row.Append(cell);

         workbookPart.Workbook.Save();
         SpreadsheetDocument.Dispose();
       }
    }
}


