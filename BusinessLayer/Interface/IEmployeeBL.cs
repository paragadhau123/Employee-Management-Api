using CommonLayer.Model;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IEmployeeBL
    {
        List<Employee> GetEmployeeDetails();

        bool DeleteEmployeeById(string id);

        bool EditEmployeeDetails(string id, Employee employee);

        Employee AddEmployee(Employee employee);
    }
}
