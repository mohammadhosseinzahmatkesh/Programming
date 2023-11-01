using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int A = 3 * 5;
            double B = 3 / 2;
            char C = 'a';
            string D = ("hello");
            bool E = false;

            Console.WriteLine(A);

            Console.WriteLine(B);

            Console.WriteLine(C + D);

            Console.WriteLine(E);
        }
    }
}
