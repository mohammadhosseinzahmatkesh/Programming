using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            // Now outputs Opel instead of Volvo
            Console.WriteLine(cars.Length);
            // Outputs 4

            string[] mashin = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in mashin)
            {
                Console.WriteLine(i);
            }

            // Sort a string
            string[] BB = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
