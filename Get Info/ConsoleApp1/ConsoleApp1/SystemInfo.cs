using ConsoleApp1;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SystemInfo
    {
        CPU GetCPU = new CPU();
        RAM GetRAM = new RAM();
        GPU GetGPU = new GPU();
        Hard GetHard = new Hard();

        public List<string> List = new List<string>();

        public void GetInfo()
        {
            GetCPU.GetCPU(List);
            //
            GetRAM.GetRAM(List);
            //
            GetHard.GetHard(List);
            //
            GetGPU.GetCPU(List);
        }
    }   
}
