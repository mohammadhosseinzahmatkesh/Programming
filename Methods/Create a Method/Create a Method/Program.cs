using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
        }
        private static void MyMethod()
        {
            string fname = Console.ReadLine();
            string AGE = Console.ReadLine();
            int age = Convert.ToInt32(AGE);
            Console.WriteLine(fname + " is " + age);
        }
    }
}
