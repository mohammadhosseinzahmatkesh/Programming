using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SystemInfo
    {
        public string main(string hwclass, string syntex)
        {
            string A = string.Empty;
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
                foreach (ManagementObject mj in mos.Get())
                {
                    A = Convert.ToString(mj[syntex]);
                    Console.WriteLine(Convert.ToString(mj[syntex]));
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return A;
        }
    }
}
