using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GPU
    {
        public List<string> GetCPU(List<string> List4)
        {
            GetInfo Info = new GetInfo();




            List4.Add("Model GPU:");
            //
            List4.Add(Info.information("Win32_VideoController", "Name"));



            return List4;
        }
    }
}
