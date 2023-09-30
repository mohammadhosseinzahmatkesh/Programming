using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int i = Convert.ToInt32(a);
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            string A = Console.ReadLine();
            int I = Convert.ToInt32(A);
            do
            {
                Console.WriteLine(I);
                I++;
            }
            while (I < 5);
        }
    }
}
