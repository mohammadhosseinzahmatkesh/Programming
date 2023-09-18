using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question
    {
        public void main ()
        {
            try
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
                    xlsx.excel();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("not available in the list!");
                    main();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
