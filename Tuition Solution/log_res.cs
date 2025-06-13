using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Tuition_Solution
{
    internal class log_res
    {


        public static string GetProcessorId()
        {
            foreach (var obj in new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor").Get())
            {
                return obj["ProcessorId"]?.ToString();
            }
            return null;
        }


        public static string GetMotherboardId()
        {
            foreach (var obj in new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard").Get())
            {
                return obj["SerialNumber"]?.ToString();
            }
            return null;
        }
    }


   

}
