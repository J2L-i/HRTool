using System;
using System.Collections.Generic;
using System.Text;

namespace HRTool.Models
{
    /// <summary>
    /// The EmployeeComposite class is a concrete implementation of 
    /// the EmployeeComponent abstract class, and represents a composite 
    /// employee, which is a group of employees. I
    /// </summary>
    internal class EmployeeComposite : EmployeeComponent
    {
        // The list of subordinate employees.
        private List<EmployeeComponent> subordinates;

        // Constructs a new composite employee with the given name.
        public EmployeeComposite(string name,string rank) : base(name,rank)
        {
            subordinates = new List<EmployeeComponent>();
        }

        
        public override void Add(EmployeeComponent component)
        {
            subordinates.Add(component);
            employeeCount++;
        }

        public override void Remove(EmployeeComponent component)
        {
            subordinates.Remove(component);
            employeeCount--;
        }

        public override int GetEmployeeCount()
        {
            int count = 0;
            foreach (EmployeeComponent subordinate in subordinates)
            {
                count += subordinate.GetEmployeeCount();
            }
            return count + 1; // add 1 to count the current manager
        }

        public override string Display(int depth)
        {
            string indent = new string('-', depth);
            string display = $"{indent} {name} ({rank}) - Employees: {GetEmployeeCount()}\n";
            foreach (EmployeeComponent subordinate in subordinates)
            {
                display += $"\n{indent}\n{subordinate.Display(depth + 1)}";
            }
            return display;
        }
    }

}
