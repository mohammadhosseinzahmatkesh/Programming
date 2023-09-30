using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_els
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it?");
            string T = Console.ReadLine();
            int time = Convert.ToInt32(T);
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 16)
            {
                Console.WriteLine("Good noon");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good after noon");
            }
            else
            {
                Console.WriteLine("Good nitgh.");
            }
        }
    }
}
