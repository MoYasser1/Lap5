using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap5
{

    public class SocialInsurance
    {
        public void OnEmployeeAdded(string employeeName)
        {
            Console.WriteLine($"Social insurance for {employeeName} has been started.");
        }
    }


}
