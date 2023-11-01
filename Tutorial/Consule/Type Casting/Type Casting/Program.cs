using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //casting
            int A = 5;
            double B = A;
            //Implicit casting is done automatically when passing a smaller size type to a larger size type.

            double C = 9.75;
            int D = (int)C;
            //Explicit casting must be done manually by placing the type in parentheses in front of the value.

            /*Console.WriteLine(Convert.ToString(myInt));    // convert int to string
               Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
               Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
               Console.WriteLine(Convert.ToString(myBool));   // convert bool to string*/
        }
    }
}
