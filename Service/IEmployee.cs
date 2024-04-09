using HRTool.Models;

namespace HRTool.Service
{
    internal interface IEmployee
    {
        int Id { get; }
        string Name { get; }
        int Level { get; }
        bool Available { get; }
        EmployeeComposite Subordinates { get; }
    }
}
