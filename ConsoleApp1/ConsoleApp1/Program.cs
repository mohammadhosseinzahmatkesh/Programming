using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Diagnostics;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" +
                             "\n * Please choose the option you want:                                                                                *" +
                             "\n * 1-CPU)                                                                                                            *" +
                             "\n * 2-GPU)                                                                                                            *" +
                             "\n * 3-RAM)                                                                                                            *" +
                             "\n * 4-HARD)                                                                                                           *" +
                             "\n * 5-Exit)                                                                                                           *" +
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
                cpu("Win32_Processor" ,"Name");
                qusn();
            }

            else if (num == 2)
            {
                Console.Clear();
                cpu("Win32_VideoController", "Name");
                //cpu("Win32_BaceBoard", "Product");
                qusn();
            }

            else if (num == 3)
            {
                Console.Clear();
                cpu("Win32_PhysicalMemory ", "Name");
                qusn();
            }

            else if (num == 3)
            {


                qusn();
            }

            else if (num == 5)
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

                Console.WriteLine("The entered number is not available in the list!");
                qusn();
            }

            void qusn()
            {
                Console.WriteLine("\r\nPress the 'B' key to return to the main menu and the 'E' key to exit.");
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

            }
        }

        private static void cpu(string hwclass, string syntex)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                Console.WriteLine(Convert.ToString(mj[syntex]));
            }
        }
    }
}
