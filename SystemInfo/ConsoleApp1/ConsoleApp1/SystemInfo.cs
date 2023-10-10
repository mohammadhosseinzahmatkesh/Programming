using ConsoleApp1;
using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
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
        List<string> Xlsx = new List<string>();
        
        public void System()
        {
            Console.Clear();

            Xlsx.Add("Model:");
            //
            Xlsx.Add("PC Name:");
            //
            Xlsx.Add("Manufacturer:");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Console.Write("Model:" + "               ");
            Xlsx.Add(Info.information("Win32_ComputerSystem", "Model"));
            //  
            Console.Write("PC Name:" + "             ");
            Xlsx.Add(Info.information("Win32_ComputerSystem", "Name"));
            //
            Console.Write("Manufacturer:" + "        ");
            Xlsx.Add(Info.information("Win32_ComputerSystem", "Manufacturer"));
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
        }


        public void CPU()
        {
            Console.Clear();

            Xlsx.Add("Model:");
            //
            Xlsx.Add("cores:");
            //
            Xlsx.Add("logical:");
            //
            Xlsx.Add("Frequency:");
            //
            Xlsx.Add("");
            //
            Console.Write("Model:" + "            ");
            Xlsx.Add(Info.information("Win32_Processor", "Name"));
            //
            Console.Write("cores:" + "            ");
            Xlsx.Add(Info.information("Win32_Processor", "NumberOfCores"));
            //
            Console.Write("logical:" + "          ");
            Xlsx.Add(Info.information("Win32_Processor", "NumberOfCores"));
            //
            Console.Write("Frequency:" + "        ");
            Xlsx.Add(Info.information("Win32_Processor", "MaxClockSpeed"));
            //
            Xlsx.Add("");
        }


        public void GPU()
        {
            Console.Clear();

            Xlsx.Add("Model:");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Console.Write("Model:" + "     ");
            Xlsx.Add(Info.information("Win32_VideoController", "Name"));
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
        }


        public void RAM()
        {
            Console.Clear();

            Xlsx.Add("TotalPhysicalMemory:");
            //
            Xlsx.Add("NumberOfProcessors:");
            //
            Xlsx.Add("Capacity:");
            //
            Xlsx.Add("MemoryType:");
            //
            Xlsx.Add("Frequency");
            //
            Console.Write("TotalPhysicalMemory:" + "       ");
            Xlsx.Add(Info.information("Win32_ComputerSystem", "TotalPhysicalMemory"));
            //
            Console.Write("\nNumberOfProcessors:" + "        ");
            Xlsx.Add(Info.information("Win32_ComputerSystem", "NumberOfProcessors"));
            //
            Console.Write("\nCapacity:" + "     " + "\n");
            Xlsx.Add(Info.information("Win32_PhysicalMemory", "Capacity"));
            //
            Console.Write("\nMemoryType:" + "     " + "\n");
            Xlsx.Add(Info.information("Win32_PhysicalMemory", "MemoryType"));
            //
            Console.Write("\nFrequency:" + "     " + "\n");
            Xlsx.Add(Info.information("Win32_PhysicalMemory", "Speed"));
        }


        public void Hard()
        {
            Console.Clear();

            Xlsx.Add("Name:");
            //
            Xlsx.Add("Model:");
            //
            Xlsx.Add("Size:");
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
            //
            Console.Write("Name:\n");
            Xlsx.Add(Info.information("Win32_DiskDrive", "Name"));
            //
            Console.Write("\nModel:\n");
            Xlsx.Add(Info.information("Win32_DiskDrive", "Caption"));
            //
            Console.Write("\nSize:\n");
            Xlsx.Add(Info.information("Win32_DiskDrive", "BytesPerSector"));
            //
            Xlsx.Add("");
            //
            Xlsx.Add("");
        }


        public void Exsel()
        {
            Xlsx save = new Xlsx();
            save.excel(Xlsx);
        } 
    }
}
