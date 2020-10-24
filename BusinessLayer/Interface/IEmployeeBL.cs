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

        Employee AddEmployee(EmployeeModel employee);
    }
}
