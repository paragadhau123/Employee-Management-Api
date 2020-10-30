using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IEmployeeRL
    {
        List<Employee> GetEmployeeDetails();

        bool EditEmployeeDetails(string id, Employee employee);

        bool DeleteEmployeeById(string id);

        Employee AddEmployee(Employee employee);
    }
}
