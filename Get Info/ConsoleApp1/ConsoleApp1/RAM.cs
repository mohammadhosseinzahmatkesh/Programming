using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RAM
    {
        public List<string> GetRAM(List<string>List2)
        {
            GetInfo Info = new GetInfo();



            List2.Add("TotalPhysicalMemory:");
            //
            List2.Add(Info.information("Win32_ComputerSystem", "TotalPhysicalMemory"));
            //
            List2.Add("Frequency Memory");
            //                  
            List2.Add(Info.information("Win32_PhysicalMemory", "Speed"));



            return List2;
        }
    }
}
