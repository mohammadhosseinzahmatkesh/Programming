using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{


    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(" * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * " +
                    "\n * Please choose the option you want:  \t \t \t \t \t \t \t \t \t \t     * " +
                    "\n * 1-Square)\t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * 2-triangle) \t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * 3-Diamond) \t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * 4-Exit) \t \t \t \t \t \t \t \t \t \t \t \t  \t     *" +
                    "\n * \t \t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * \t \t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * Please enter the desired number here: \t \t \t \t \t \t \t \t \t     *"+
                    "\n * \t \t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * \t \t \t \t \t \t \t \t \t \t \t \t \t \t     *" +
                    "\n * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * \n");
           
           int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                Console.Clear();

                int Size;

                Console.WriteLine("Enter the size of the square: ");

                Size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int row = 0; row < Size; row++)
                {
                    for (int column = 0; column < Size; column++)
                    {
                        if (row == 0 || column == 0 || row == Size - 1 || column == Size - 1)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
                    qusn();
            }

            else if (a == 2)
            {
                Console.Clear();

                int Size;
                Console.WriteLine("Enter the size of the square: ");
                Size = Convert.ToInt32(Console.ReadLine());
                int counts = 5 + (Size / 2);
                for (int i = 1; i <= Size; i += 2)
                {
                    for (int c = 1; c <= counts; c++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 1; j <= i; ++j)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    counts--;
                }
                qusn();
            }

            else if (a == 3)
            {
                Console.Clear();

                int Size;
                Console.WriteLine("Enter the size of the square: ");
                Size = Convert.ToInt32(Console.ReadLine());
                int counts = 5 + (Size / 2);
                for (int i = 1; i <= Size; i += 2)
                {
                    for (int c = 1; c <= counts; c++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 1; j <= i; ++j)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    counts--;
                }

                if (Size % 2 == 0) Size -= 1;

                counts++;
                for (int i = Size ; i > 0; i -= 2)
                {
                    for (int c = 1; c <= counts; c++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 1; j <= i; ++j)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    counts++;
                }
                qusn();
            }


            else if (a == 4)
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

    }
}
