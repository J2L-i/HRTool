namespace HRTool.Service
{
    internal interface IEmployeeFactory
    {
        IEmployee CreateEmployee(int id, string name, int level);
    }
}
