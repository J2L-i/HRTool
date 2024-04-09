using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRTool.Models
{
    internal abstract class Approver
    {
        protected Approver _nextApprover;

        public void SetNextApprover(Approver nextApprover)
        {
            _nextApprover = nextApprover;
        }

        public abstract void ProcessRequest(TimeOffRequest request);
    }
}
