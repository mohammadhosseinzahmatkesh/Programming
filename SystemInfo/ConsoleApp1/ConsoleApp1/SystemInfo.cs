using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SystemInfo
    {
        public void main(string hwclass, string syntex)
        {
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
                foreach (ManagementObject mj in mos.Get())
                {
                    Console.WriteLine(Convert.ToString(mj[syntex]));
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
