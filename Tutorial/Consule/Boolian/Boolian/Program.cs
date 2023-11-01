using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Vote;
            string A = Console.ReadLine();
            int B = Convert.ToInt32(A);
            Vote = B >=18 ;
            Console.WriteLine("Your voting result is:" + Vote);
        }
    }
}
