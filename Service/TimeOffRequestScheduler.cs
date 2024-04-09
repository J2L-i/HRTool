using System;
using System.Collections.Generic;
using HRTool.Models;

namespace HRTool.Service
{
    internal class TimeOffRequestScheduler
    {
        private readonly object _lock = new object();
        private readonly Queue<TimeOffRequest> _pendingRequests = new Queue<TimeOffRequest>();
        private bool _processingRequest = false;

        public void ScheduleRequest(TimeOffRequest request)
        {
            lock (_lock)
            {
                _pendingRequests.Enqueue(request);
            }
        }

        public bool HasNextRequest()
        {
            lock (_lock)
            {
                return _pendingRequests.Count > 0;
            }
        }

        public TimeOffRequest ProcessNextRequest()
        {
            lock (_lock)
            {
                if (_processingRequest || _pendingRequests.Count == 0)
                {
                    return null;
                }

                _processingRequest = true;

                TimeOffRequest request = _pendingRequests.Dequeue();
                Approver approver = request.GetNextApprover();
                Console.WriteLine(request.Employee.Name);
                if (approver != null)
                {
                    approver.ProcessRequest(request);
                }

                _processingRequest = false; // Mark request as processed
                return request;
            }
        }
    }
}
