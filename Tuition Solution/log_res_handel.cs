using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Tuition_Solution
{
    internal class log_res_handel
    {

        public static string GetProcessorId()
        {
            foreach (var obj in new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor").Get())
            {
                return obj["ProcessorId"]?.ToString();
            }
            return null;
        }




    }
}
}
