using System;

namespace HRTool.Models
{
    /// <summary>
    /// The abstract base class for all employees in the employee hierarchy.
   
    internal abstract class EmployeeComponent
    {
        protected string name;
        protected int employeeCount;
        protected string rank;

        /// <summary>
        /// Initializes a new instance of the EmployeeComponent class with the specified name.
        /// </summary>
        /// <param name="name"></param>
        public EmployeeComponent(string name, string rank)
        {
            this.name = name;
            this.rank = rank;
        }
        /// <summary>
        /// Adds the specified EmployeeComponent object as a subordinate of this employee.
        /// </summary>
        /// <param name="component"></param>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void Add(EmployeeComponent component)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Removes the specified EmployeeComponent object from the list 
        /// of subordinates of this employee.
        /// </summary>
        /// <param name="component"></param>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void Remove(EmployeeComponent component)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns the total number of employees under this employee in the hierarchy.
        /// </summary>
        /// <returns></returns>
        public virtual int GetEmployeeCount()
        {
            return employeeCount;
        }
        /// <summary>
        /// Displays the information about the employee and its subordinates in a
        /// hierarchical format with appropriate indentation.
        /// </summary>
        /// <param name="depth"></param>
        public abstract string Display(int depth);
    }

}
