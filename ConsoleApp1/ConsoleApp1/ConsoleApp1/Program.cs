using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" +
                             "\n * Please choose the option you want:                                                                                *" +
                             "\n * 1-System)                                                                                                         *" +
                             "\n * 2-CPU)                                                                                                            *" +
                             "\n * 3-GPU)                                                                                                            *" +
                             "\n * 4-RAM)                                                                                                            *" +
                             "\n * 5-HARD)                                                                                                           *" +
                             "\n * 6-Exit)                                                                                                           *" +
                             "\n *                                                                                                                   *" +
                             "\n *                                                                                                                   *" +
                             "\n * Please enter the desired number here:                                                                             *" +
                             "\n *                                                                                                                   *" +
                             "\n *                                                                                                                   *" +
                             "\n * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" );



            int num = int.Parse(Console.ReadLine());
            

            if (num == 1)
            {
                Console.Clear();
                
                Console.Write("Model:" + "               "              );
                SystemInfo("Win32_ComputerSystem",        "Model"       );
                // 
                Console.Write("Pc Name:" + "             "              );
                SystemInfo("Win32_ComputerSystem",         "Name"       );
                //
                Console.Write("Manufacturer:" + "        "              );
                SystemInfo("Win32_ComputerSystem", "Manufacturer"       );
                
                Q();
            }



            if (num == 2)
            {
                Console.Clear();

                Console.Write("Model:" + "            "                 );
                SystemInfo("Win32_Processor" ,          "Name"          );
                //
                Console.Write("cores:" + "            "                 );
                SystemInfo("Win32_Processor" , "NumberOfCores"          );
                //
                Console.Write("logical:" + "          "                 );
                SystemInfo("Win32_Processor" , "NumberOfCores"          );
                //
                Console.Write("speed:" + "            "                 );
                SystemInfo("Win32_Processor", "MaxClockSpeed"           );

                Q();
            }



            else if (num == 3)
            {
                Console.Clear();

                Console.Write("Model:" + "     ");
                SystemInfo("Win32_VideoController", "Name"              );
                Q();
            }



            else if (num == 4)
            {
                Console.Clear();
                Console.Write("TotalPhysicalMemory:" + "       "        );
                SystemInfo("Win32_ComputerSystem", "TotalPhysicalMemory");
                //
                Console.Write("NumberOfProcessors:" + "        "        );
                SystemInfo("Win32_ComputerSystem", "NumberOfProcessors" );
                //
                Console.Write("\nCapacity:" + "     " + "\n"            );
                SystemInfo("Win32_PhysicalMemory", "Capacity"           );
                //
                Console.Write("\nMemoryType:" + "     " + "\n"          );
                SystemInfo("Win32_PhysicalMemory", "MemoryType"         );
                //
                Console.Write("\nSpeed:" + "     " + "\n"               );
                SystemInfo("Win32_PhysicalMemory", "Speed"              );
                Q();
            }



            else if (num == 5)
            {
                Console.Clear();

                Console.Write("Name:" + "     "                         );
                SystemInfo("Win32_DiskDrive", "Name"                    );
                //
                Console.Write("Model:" + "    "                         );
                SystemInfo("Win32_DiskDrive", "Caption"                 );
                //
                Console.Write("Size:" + "     "                         );
                SystemInfo("Win32_DiskDrive" , "BytesPerSector"         ); 
 
                Q();
            }



            else if (num == 6)
            {
                Console.Clear();
                Console.WriteLine(" Are you sure about the exit?   Y=Yes    N=NO ");
                var info = Console.ReadKey();
                if (info.Key == ConsoleKey.Y)
                {
                    Environment.Exit(0);
                }
                else if (info.Key == ConsoleKey.N)
                {
                    var fileName = Assembly.GetExecutingAssembly().Location;
                    System.Diagnostics.Process.Start(fileName);
                    Environment.Exit(0);
                }
            }



            else
            {
                Console.Clear();
                Console.WriteLine("not available in the list!");
                Q();
            }



            void Q()
            {
                Console.WriteLine("\nPress the 'S' key to the (Save),'B' key to return to the main (Menu) and the 'E' key to (Exit).");
                var info = Console.ReadKey();
                if (info.Key == ConsoleKey.B)
                {
                    var fileName = Assembly.GetExecutingAssembly().Location;
                    System.Diagnostics.Process.Start(fileName);
                    Environment.Exit(0);
                }
                else if (info.Key == ConsoleKey.E)
                {
                    Environment.Exit(0);
                }
                else if (info.Key == ConsoleKey.S)
                {
                    xlsx xlsx = new xlsx();
                    xlsx.main();    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("not available in the list!");
                    Q();
                }
            }
        }
        private static void SystemInfo(string hwclass, string syntex)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                Console.WriteLine(Convert.ToString(mj[syntex]));
            }
        }
    }
}
