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
using DocumentFormat.OpenXml.EMMA;

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



           
            SystemInfo Info = new SystemInfo();
            //
            string A2;
            string B2;
            string C2;
            string D2;
            string E2;
            //

            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.Clear();

                    Console.Write("Model:" + "               ");
                    A2 = Info.main("Win32_ComputerSystem", "Model");
                    //  
                    Console.Write("Pc Name:" + "             ");
                    B2 = Info.main("Win32_ComputerSystem", "Name");
                    //
                    Console.Write("Manufacturer:" + "        ");
                    C2 = Info.main("Win32_ComputerSystem", "Manufacturer");
                    //
                    D2 = "";
                    //
                    E2 = "";

                    S();
                }

                if (num == 2)
                {
                    Console.Clear();

                    Console.Write("Model:" + "            ");
                    A2 = Info.main("Win32_Processor", "Name");
                    //
                    Console.Write("cores:" + "            ");
                    B2 = Info.main("Win32_Processor", "NumberOfCores");
                    //
                    Console.Write("logical:" + "          ");
                    C2 = Info.main("Win32_Processor", "NumberOfCores");
                    //
                    Console.Write("Frequency:" + "        ");
                    D2 = Info.main("Win32_Processor", "MaxClockSpeed");
                    //
                    E2 = "";

                    S();
                }



                else if (num == 3)
                {
                    Console.Clear();

                    Console.Write("Model:" + "     ");
                    A2 = Info.main("Win32_VideoController", "Name");
                    //
                    B2 = "";
                    //
                    C2 = "";
                    //
                    D2 = "";
                    //
                    E2 = "";

                    S();
                }



                else if (num == 4)
                {
                    Console.Clear();
                    Console.Write("TotalPhysicalMemory:" + "       ");
                    A2 = Info.main("Win32_ComputerSystem", "TotalPhysicalMemory");
                    //
                    Console.Write("\nNumberOfProcessors:" + "        ");
                    B2 = Info.main("Win32_ComputerSystem", "NumberOfProcessors");
                    //
                    Console.Write("\nCapacity:" + "     " + "\n");
                    C2 = Info.main("Win32_PhysicalMemory", "Capacity");
                    //
                    Console.Write("\nMemoryType:" + "     " + "\n");
                    D2 = Info.main("Win32_PhysicalMemory", "MemoryType");
                    //
                    Console.Write("\nFrequency:" + "     " + "\n");
                    E2 = Info.main("Win32_PhysicalMemory", "Speed");

                    S();
                }



                else if (num == 5)
                {
                    Console.Clear();

                    Console.Write("Name:\n");
                    A2 = Info.main("Win32_DiskDrive", "Name");
                    //
                    Console.Write("\nModel:\n");
                    B2 = Info.main("Win32_DiskDrive", "Caption");
                    //
                    Console.Write("\nSize:\n");
                    C2 = Info.main("Win32_DiskDrive", "BytesPerSector");
                    //
                    D2 = "";
                    //
                    E2 = "";

                    S();
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
            }

            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("not available in the list!");
            }


            void Q()
            {
                try
                {
                    Console.WriteLine("\nPress the 'B' key to return to the main (Menu) and the 'E' key to (Exit).");
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



                    else
                    {
                        Console.Clear();
                        Console.WriteLine("not available in the list!");
                        Q();
                    }
                }

                catch
                {

                }
            }

            void S()
            {
                try
                {
                    Console.WriteLine("\nDo you want to save the file in Excel?        Y=Yes          N=No  ");

                    var E = Console.ReadKey();
                    if (E.Key == ConsoleKey.Y)
                    {
                        xlsx save = new xlsx();
                        save.excel(A2, B2, C2, D2, E2);

                        Q();
                    }



                    else if (E.Key == ConsoleKey.N)
                    {
                        Q();
                    }



                    else
                    {
                        Console.WriteLine("\nnot available in the list!");
                        Q();
                    }
                }
                catch
                {

                }
            }
        }
    }
}
