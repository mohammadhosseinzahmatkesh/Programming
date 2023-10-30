﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    internal class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }


        public static double Sustraction(double n1, double n2)
        {
            return n1 - n2;
        }


        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }


        public static double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                MessageBox.Show("Division by not supported" , "Wrong operation" , MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }

            return n1 / n2;
        }
    }
}
