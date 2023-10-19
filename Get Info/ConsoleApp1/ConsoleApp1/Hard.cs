using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hard
    {
        public List<string> GetHard(List<string> List3)
        {
            GetInfo Info = new GetInfo();



            List3.Add("Model DiskHard:");
            //
            List3.Add(Info.information("Win32_DiskDrive", "Caption"));
            //
            List3.Add("Size DiskHard:");
            //
            List3.Add(Info.information("Win32_DiskDrive", "BytesPerSector"));



            return List3;
        }
    }
}
