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
        public List<string> List = new List<string>();
        GetInfo Info = new GetInfo();

        public void GetInfo()
        {
            GetCPU(List);
            //
            GetRAM(List);
            //
            GetHard(List);
            //
            GetGPU(List);
        }



        private List<string> GetCPU(List<string> List1)
        {
            string CPU = (Info.information("Win32_Processor", "Name"));

            string[] Split = CPU.Split(' ');

            bool test1 = CPU.Contains("Intel");
            bool test2 = CPU.Contains("Ryzen");


            if (test1 == true)
            {
                List1.Add("Processor");
                //
                List1.Add(Split[1]);
                //
                List1.Add("Processor generation");
                //
                List1.Add(Split[2]);
                //
                List1.Add("Frequency CPU:");
                //
                List1.Add(Split[5]);
            }

            else if (test2 == true)
            {
                List1.Add("Processor:");
                //
                List1.Add(Split[2]);
                //
                List1.Add("Processor generation:");
                //
                List1.Add(Split[3]);
                //
                List1.Add("Frequency CPU:");
                //
                List1.Add(Info.information("Win32_Processor", "MaxClockSpeed"));
            }

            else
            {
                List1.Add("Model");
                //
                List1.Add(Info.information("Win32_Processor", "Name"));
                //
                List1.Add("");
                //
                List1.Add("");
                //
                List1.Add("Frequency CPU:");
                //
                List1.Add(Info.information("Win32_Processor", "MaxClockSpeed"));
            }

            return List1;
        }



        private List<string> GetRAM(List<string> List2)
        {
            List2.Add("TotalPhysicalMemory:");
            //
            List2.Add(Info.information("Win32_ComputerSystem", "TotalPhysicalMemory"));
            //
            List2.Add("Frequency Memory");
            //                  
            List2.Add(Info.information("Win32_PhysicalMemory", "Speed"));

            return List2;
        }



        private List<string> GetHard(List<string> List3)
        {
            List3.Add("Model DiskHard:");
            //
            List3.Add(Info.information("Win32_DiskDrive", "Caption"));
            //
            string Size = (Info.information("Win32_DiskDrive", "BytesPerSector")) + (" ") + ("DoesNotExist");
            string[] Split = Size.Split(' ');
            //
            List3.Add("Size DiskHard1:");
            //
            List.Add(Split[0]);
            //
            List3.Add("Size DiskHard2:");
            //
            List.Add(Split[1]);

            return List3;
        }



        private List<string> GetGPU(List<string> List4)
        {

            List4.Add("Model GPU:");
            //
            List4.Add(Info.information("Win32_VideoController", "Name"));

            return List4;
        }
    }   
}
