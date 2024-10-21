using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap5
{
    public class Club
    {
        public void OnEmployeeAdded(string employeeName)
        {
            Console.WriteLine($"Employee {employeeName} has been added to the club.");
        }
    }

}
