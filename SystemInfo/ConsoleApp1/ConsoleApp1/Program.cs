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
            SystemInfo SystemInfo = new SystemInfo();


            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" +
                             "\n * Please choose the option you want:                                                                                *" +
                             "\n * 1-System)                                                                                                         *" +
                             "\n * 2-CPU)                                                                                                            *" +
                             "\n * 3-GPU)                                                                                                            *" +
                             "\n * 4-RAM)                                                                                                            *" +
                             "\n * 5-Hard)                                                                                                           *" +
                             "\n * 6-Exit)                                                                                                           *" +
                             "\n *                                                                                                                   *" +
                             "\n *                                                                                                                   *" +
                             "\n * Please enter the desired number here:                                                                             *" +
                             "\n *                                                                                                                   *" +
                             "\n *                                                                                                                   *" +
                             "\n * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" );
            

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    SystemInfo.System();
                    Question();
                }



                else if (number == 2)
                {
                    SystemInfo.CPU();
                    Question();
                }



                else if (number == 3)
                {
                    SystemInfo.GPU();
                    Question();
                }



                else if (number == 4)
                {
                    SystemInfo.RAM();
                    Question();
                }



                else if (number == 5)
                {
                    SystemInfo.Hard();
                    Question();
                }



                else if (number == 6)
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
                    Console.WriteLine("not available in the list!\n");

                    Question();
                }
            }

            catch (Exception Erorr)
            {
                Console.Clear();
                Console.WriteLine("not available in the list!");
            }


           

            void Question()
            {
                try
                {
                     Console.WriteLine("\n\nPress the 'B' key to return to the main (Menu) and the 'E' key to (Exit).");
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

                            Question();
                     }
                }

                catch
                {

                }
            }
        }
    }
}
