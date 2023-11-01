using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            int Time = Convert.ToInt32(time);
            if (Time<11)
            {
                Console.WriteLine("good morning");
            }

            else if (Time<16)
            {
                Console.WriteLine("good noon");
            }

            else if (Time < 20)
            {
                Console.WriteLine("good after noon");
            }

            else
            {
                Console.WriteLine("good night");
            }
        }
    }
}
