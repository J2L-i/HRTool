using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRTool.Models
{
    internal class Manager : Employee
    {
        public Manager(int id, string name, int level) : base(id, name, level)
        {
        }

        public override void ProcessRequest(TimeOffRequest request)
        {
            bool valid = (request.EndDate - request.StartDate).Days >= 1;
            if (valid)
            {
                Console.WriteLine("Time off request approved by Manager");
                request.Employee.Available = false;
            }
            else if (_nextApprover != null)
            {
                _nextApprover.ProcessRequest(request);
            }
            else
            {
                Console.WriteLine("Time off request denied by all approvers");
            }
        }
    }
}
