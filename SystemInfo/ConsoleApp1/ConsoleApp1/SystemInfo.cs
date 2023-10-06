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
        string A1;
        string A2;
        string A3;
        string A4;
        string A5;
        string B1;
        string B2;
        string B3;
        string B4;
        string B5;
        //
        public void System()
        {
            Console.Clear();

            A1 = "Model:";
            //
            A2 = "PC Name:";
            //
            A3 = "Manufacturer:";
            //
            A4 = "";
            //
            A5 = "";
            //
            Console.Write("Model:" + "               ");
            B1 = (Info.information("Win32_ComputerSystem", "Model"));
            //  
            Console.Write("PC Name:" + "             ");
            B2 = (Info.information("Win32_ComputerSystem", "Name"));
            //
            Console.Write("Manufacturer:" + "        ");
            B3 = (Info.information("Win32_ComputerSystem", "Manufacturer"));
            //
            B4 = "";
            //
            B5 = "";

            Save();
        }


        public void CPU()
        {
            Console.Clear();

            A1 = "Model:";
            //
            A2 = "cores:";
            //
            A3 = "logical:";
            //
            A4 = "Frequency:";
            //
            A5 = "";
            //
            Console.Write("Model:" + "            ");
            B1 = Info.information("Win32_Processor", "Name");
            //
            Console.Write("cores:" + "            ");
            B2 = Info.information("Win32_Processor", "NumberOfCores");
            //
            Console.Write("logical:" + "          ");
            B3 = Info.information("Win32_Processor", "NumberOfCores");
            //
            Console.Write("Frequency:" + "        ");
            B4 = Info.information("Win32_Processor", "MaxClockSpeed");
            //
            B5 = "";

            Save();
        }


        public void GPU()
        {
            Console.Clear();

            A1 = "Model:";
            //
            A2 = "";
            //
            A3 = "";
            //
            A4 = "";
            //
            A5 = "";
            //
            Console.Write("Model:" + "     ");
            B1 = Info.information("Win32_VideoController", "Name");
            //
            B2 = "";
            //
            B3 = "";
            //
            B4 = "";
            //
            B5 = "";

            Save();
        }


        public void RAM()
        {
            Console.Clear();

            A1 = "Win32_ComputerSystem";
            //
            A2 = "NumberOfProcessors:";
            //
            A3 = "Capacity:";
            //
            A4 = "MemoryType:";
            //
            A5 = "Frequency";
            //
            Console.Write("TotalPhysicalMemory:" + "       ");
            B1 = Info.information("Win32_ComputerSystem", "TotalPhysicalMemory");
            //
            Console.Write("\nNumberOfProcessors:" + "        ");
            B2 = Info.information("Win32_ComputerSystem", "NumberOfProcessors");
            //
            Console.Write("\nCapacity:" + "     " + "\n");
            B3 = Info.information("Win32_PhysicalMemory", "Capacity");
            //
            Console.Write("\nMemoryType:" + "     " + "\n");
            B4 = Info.information("Win32_PhysicalMemory", "MemoryType");
            //
            Console.Write("\nFrequency:" + "     " + "\n");
            B5 = Info.information("Win32_PhysicalMemory", "Speed");

            Save();
        }


        public void Hard()
        {
            Console.Clear();

            A1 = "Name:";
            //
            A2 = "Model:";
            //
            A3 = "Size:";
            //
            A4 = "";
            //
            A5 = "";
            //
            Console.Write("Name:\n");
            B1 = Info.information("Win32_DiskDrive", "Name");
            //
            Console.Write("\nModel:\n");
            B2 = Info.information("Win32_DiskDrive", "Caption");
            //
            Console.Write("\nSize:\n");
            B3 = Info.information("Win32_DiskDrive", "BytesPerSector");
            //
            B4 = "";
            //
            B5 = "";

            Save();
        }

        void Save()
        {
            try
            {
                Console.WriteLine("\nDo you want to save the file in Excel?        Y=Yes          N=No  ");

                var E = Console.ReadKey();
                if (E.Key == ConsoleKey.Y)
                {
                    xlsx save = new xlsx();
                    save.excel(A1,A2,A3,A4,A5,B1,B2,B3,B4,B5);
                }



                else if (E.Key == ConsoleKey.N)
                {
                    
                }



                else
                {
                    Console.WriteLine("\nnot available in the list!");
                    Save();
                }
            }
            catch
            {

            }
        }

    }
}
