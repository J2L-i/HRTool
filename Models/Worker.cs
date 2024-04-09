
using System;

namespace HRTool.Models
{
    internal class Worker : Employee
    {
        public Worker(int id, string name, int level) : base(id, name, level)
        {
        }

        public override void ProcessRequest(TimeOffRequest request)
        {
           Console.WriteLine("Normal employee (Worker) approves nothing! Sorry");
        }
    }
}
