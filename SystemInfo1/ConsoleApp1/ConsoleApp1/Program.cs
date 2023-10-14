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
using DocumentFormat.OpenXml.Office2010.ExcelAc;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            SystemInfo SystemInfo = new SystemInfo();

            try
            {
                Console.WriteLine("start\n");

                Console.WriteLine("Saving...");

                SystemInfo.GetInfo();
                
                Save();

                Console.Clear();

                Console.WriteLine("Finish\n");
            }


            catch (Exception Erorr)
            {
                Console.WriteLine(Erorr.Message);
            }


            void Save()
            {
                try
                {
                    Xlsx save = new Xlsx();
                    save.SaveExcel(SystemInfo.List);
                }
                catch (Exception Erorr)
                {
                    Console.WriteLine(Erorr.Message);
                }
            }
        }
    }
}
