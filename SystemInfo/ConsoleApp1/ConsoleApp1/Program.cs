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

            
            
            Question Q = new Question();
            //
            SystemInfo Info = new SystemInfo();

            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.Clear();

                    Console.Write("Model:" + "               ");
                    Info.main("Win32_ComputerSystem", "Model");
                    // 
                    Console.Write("Pc Name:" + "             ");
                    Info.main("Win32_ComputerSystem", "Name");
                    //
                    Console.Write("Manufacturer:" + "        ");
                    Info.main("Win32_ComputerSystem", "Manufacturer");

                    Q.main();
                }



                if (num == 2)
                {
                    Console.Clear();

                    Console.Write("Model:" + "            ");
                    Info.main("Win32_Processor", "Name");
                    //
                    Console.Write("cores:" + "            ");
                    Info.main("Win32_Processor", "NumberOfCores");
                    //
                    Console.Write("logical:" + "          ");
                    Info.main("Win32_Processor", "NumberOfCores");
                    //
                    Console.Write("Frequency:" + "            ");
                    Info.main("Win32_Processor", "MaxClockSpeed");

                    Q.main();
                }



                else if (num == 3)
                {
                    Console.Clear();

                    Console.Write("Model:" + "     ");
                    Info.main("Win32_VideoController", "Name");

                    Q.main();
                }



                else if (num == 4)
                {
                    Console.Clear();
                    Console.Write("TotalPhysicalMemory:" + "       ");
                    Info.main("Win32_ComputerSystem", "TotalPhysicalMemory");
                    //
                    Console.Write("\nNumberOfProcessors:" + "        ");
                    Info.main("Win32_ComputerSystem", "NumberOfProcessors");
                    //
                    Console.Write("\nCapacity:" + "     " + "\n");
                    Info.main("Win32_PhysicalMemory", "Capacity");
                    //
                    Console.Write("\nMemoryType:" + "     " + "\n");
                    Info.main("Win32_PhysicalMemory", "MemoryType");
                    //
                    Console.Write("\nFrequency:" + "     " + "\n");
                    Info.main("Win32_PhysicalMemory", "Speed");

                    Q.main();
                }



                else if (num == 5)
                {
                    Console.Clear();

                    Console.Write("Name:\n");
                    Info.main("Win32_DiskDrive", "Name");
                    //
                    Console.Write("\nModel:\n");
                    Info.main("Win32_DiskDrive", "Caption");
                    //
                    Console.Write("\nSize:\n");
                    Info.main("Win32_DiskDrive", "BytesPerSector");

                    Q.main();
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
                    Q.main();
                }
            }

            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("not available in the list!");
                Q.main();
            }
        }
    }
}
