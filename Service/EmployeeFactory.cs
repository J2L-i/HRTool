using System;
using HRTool.Models;

namespace HRTool.Service
{
    /// <summary>
    /// The EmployeeFactory class is a concrete implementation of the IEmployeeFactory
    /// interface. It provides a factory method CreateEmployee
    /// </summary>
    internal class EmployeeFactory : IEmployeeFactory
    {
        /// <summary>
        /// Takes in a name and a level parameter and returns an instance of the appropriate
        /// concrete class that implements the IEmployee interface. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEmployee CreateEmployee(int id,string name, int level)
        {
            switch (level)
            {
                case 0:
                    return new Executive(id, name,level);
                case 1:
                    return new Director(id, name, level);
                case 2:
                    return new Manager(id, name, level);
                case 3:
                    return new Worker(id, name, level);
                default:
                    throw new ArgumentException($"Invalid employee level: {level}");
            }
        }
    }
}
