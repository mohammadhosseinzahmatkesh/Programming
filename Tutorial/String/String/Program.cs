using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "ABCDefghIJKLmnopQRSTuvwxYz";
            Console.WriteLine(txt.ToUpper());    // Outputs "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Console.WriteLine(txt.ToLower());   // Outputs "abcdefghijklmopqrstuvwxyz"
            Console.WriteLine("The length of the txt string is: " + txt.Length);   //String Length

            //

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);           //String Concatenation

            //

            string AA = "John";
            string BB = "Doe";
            string CC = $"My full name is: {AA} {BB}";
            Console.WriteLine(CC);            //String Interpolation

            //

            string DD = "John Doe";
            Console.WriteLine(DD[0]);            // Outputs "J"
            Console.WriteLine(DD.IndexOf("o"));  // Outputs "2"

            //

            //Because strings must be written within quotes, C# will misunderstand this string, and generate an error:

            //The backslash (\) escape character turns special characters into string characters:

           //Escape character    Result                Description
           //   \'	               '                   Single quote
           //   \"                 "                   Double quote
           //   \\	               \	               Backslash
        }
    }
}
