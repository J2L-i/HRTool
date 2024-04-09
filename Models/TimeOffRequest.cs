using System;
using System.Collections.Generic;
using HRTool.Service;

namespace HRTool.Models
{
    internal class TimeOffRequest
    {
        public Employee Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeOffType Type { get; set; }
        public TimeOffRequest() { }

        private readonly List<Approver> _approvers;
        private int _currentApproverIndex;

        public TimeOffRequest(IEmployee emp, DateTime startDate, DateTime endDate, TimeOffType requestReason)
        {
            this.Employee =(Employee) emp;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Type = requestReason;
            this._approvers = new List<Approver>();
            this._currentApproverIndex = 0;
        }

        public void AddApprover(Approver approver)
        {
            _approvers.Add(approver);
        }

        public Approver GetNextApprover()
        {
            if (_currentApproverIndex < _approvers.Count)
            {
                return _approvers[_currentApproverIndex++];
            }
            return null;
        }
    }
}
