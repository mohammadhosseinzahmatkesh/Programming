using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GetInfo
    {
        public string information(string hwclass, string syntex)
        {
            string info = string.Empty;
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
                foreach (ManagementObject mj in mos.Get())
                {
                    info = Convert.ToString(mj[syntex]);
                    Console.WriteLine(Convert.ToString(mj[syntex]));
                }
            }

            catch (Exception Erorr)
            {
                Console.WriteLine(Erorr.Message);
            }
            return info;
        }
    }
}
