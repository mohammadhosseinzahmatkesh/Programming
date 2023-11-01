using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace tread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //هرکدام  با تاخیر دو ثانیه
            doAction();

            doAction();

            doAction();

            doAction();
            //
            T();
            //
            task();

        }

        private static void T()
        {
            //همه با هم با تاخیر دو ثانیه(thread سنتی)
            Thread t1 = new Thread(doAction);
            t1.Start();
            Thread t2 = new Thread(doAction);
            t2.Start();
            Thread t3 = new Thread(doAction);
            t3.Start();
            Thread t4 = new Thread(doAction);
            t4.Start();

            //به برنامه میفهماند که باید قسمت یک کامل باشد تا قسمت دو انجام شود
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
        }

        private static async void task()
        {
            //همه با هم با تاخیر دو ثانیه(thread جدید)
            Task.Run(doAction);
            Task.Run(doAction);
            Task.Run(doAction);
            await Task.Run(doAction);             //به برنامه میفهماند که باید قسمت یک کامل باشد تا قسمت دو انجام شود

        }

        private static void doAction()
        {
            Thread.Sleep(2000);
            Console.WriteLine("hi");
        }
    }
}
