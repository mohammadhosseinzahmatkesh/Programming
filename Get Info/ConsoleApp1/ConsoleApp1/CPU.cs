using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CPU
    {
        public List <string> GetCPU(List<string> List1)
        {
            GetInfo Info = new GetInfo();
            


            string CPU = (Info.information("Win32_Processor", "Name"));
            string[] C = CPU.Split(' ');
            


            if (C[0] == "Intel")
            {
                List1.Add("Processor");
                //
                List1.Add(C[1]);
                //
                List1.Add("Processor generation");
                //
                List1.Add(C[3]);
                //
                List1.Add("Frequency CPU:");
                //
                List1.Add(C[5]);
            }
            else if (C[1] == "Ryzen")
            {
                List1.Add("Processor");
                //
                List1.Add(C[2]);
                //
                List1.Add("Processor generation");
                //
                List1.Add(C[3]);
                //
                List1.Add("Frequency CPU:");
                //
                List1.Add(Info.information("Win32_Processor", "MaxClockSpeed"));
            }



            return List1;
        }
    }
}
