using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogPr
{
    public class AddNumbersPr
    {
        private readonly NLog nLog = new NLog();
        public int Addition(int num1,int num2)
        {
            if(num1==0 || num2==0)
            {
                nLog.LogDebug("Debug successfull");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("num1 and num2 shound not eqqual to 0");
            }
            int sum= num1 + num2;
            nLog.LogDebug("Debug successfull");
            nLog.LogInfo("Sum Method passed,total sum is:"+sum);
            return sum;
        }
    }
}
