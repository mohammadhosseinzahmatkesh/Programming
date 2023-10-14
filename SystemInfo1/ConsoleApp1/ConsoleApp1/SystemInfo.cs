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
        GetInfo Info = new GetInfo();
        //
        public List<string> List = new List<string>();

        public void GetInfo()
        {
           string CPU =(Info.information("Win32_Processor", "Name"));
           string[] C = CPU.Split(' ');
            //CPU
           if (C[0] == "Intel")
           {
                List.Add("Processor");
                //
                List.Add(C[1]);
                //
                List.Add("Processor generation");
                //
                List.Add(C[3]);
                //
                List.Add("Frequency CPU:");
                //
                List.Add(C[5]);
           }
           else if (C[1] == "Ryzen")
           {
                List.Add("Processor");
                //
                List.Add(C[2]);
                //
                List.Add("Processor generation");
                //
                List.Add(C[3]);
                //
                List.Add("Frequency CPU:");
                //
                List.Add(Info.information("Win32_Processor", "MaxClockSpeed"));
           }




           //RAM
            List.Add("TotalPhysicalMemory:");
            //
            List.Add(Info.information("Win32_ComputerSystem", "TotalPhysicalMemory"));
            //
            List.Add("Frequency Memory");
            //                  
            List.Add(Info.information("Win32_PhysicalMemory", "Speed"));





            //Hard
            List.Add("Model DiskHard:");
            //
            List.Add(Info.information("Win32_DiskDrive", "Caption"));
            //
            List.Add("Size DiskHard:");
            //
            List.Add(Info.information("Win32_DiskDrive", "BytesPerSector"));




            //GPU
            List.Add("Model GPU:");
            //
            List.Add(Info.information("Win32_VideoController", "Name"));
        }
    }   
}
