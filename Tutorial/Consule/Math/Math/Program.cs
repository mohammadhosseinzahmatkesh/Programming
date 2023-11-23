using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            x = -4 ;
            double y = -8;
            y = 3.22;

            Console.WriteLine(Math.Max(x,y));
            //The Math.Max(x,y) method can be used to find the highest value of x and y:

            Console.WriteLine(Math.Min(x, y));
            //The Math.Min(x,y) method can be used to find the lowest value of of x and y:

            Console.WriteLine(Math.Sqrt(64));
            //The Math.Sqrt(x) method returns the square root of x:

            Console.WriteLine(Math.Abs(x));
            //The Math.Abs(x) method returns the absolute (positive) value of x:

            Console.WriteLine(Math.Round(y));
            //Math.Round() rounds a number to the nearest whole number:

        }
    }
}
