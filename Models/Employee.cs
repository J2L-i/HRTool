using HRTool.Service;

namespace HRTool.Models
{
    /// <summary>
    /// The abstract class Employee represents a generic employee in a company, 
    /// implementing the IEmployee interface. It contains the common properties 
    /// and methods that all employees share, such as their name, level in the hierarchy,
    /// and their subordinates.
    
    internal abstract class Employee : Approver, IEmployee
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Level { get; protected set; }
        public EmployeeComposite Subordinates { get; protected set; }
        public bool Available { get; set; }


        public Employee(int id, string name, int level)
        {
            this.Id = id;
            this.Name = name;
            this.Level = level;
            switch (level)
            {
                case 0:
                    this.Subordinates = new EmployeeComposite(name,"Executive");
                    break;
                case 1:
                    this.Subordinates = new EmployeeComposite(name, "Director");
                    break;
                case 2:
                    this.Subordinates = new EmployeeComposite(name, "Manager");
                    break;
                case 3:
                    this.Subordinates = new EmployeeComposite(name, "Worker");
                    break;
                default:
                    break;
            }
            this.Available = true; // Initialize availability to true
        }
    }
}
