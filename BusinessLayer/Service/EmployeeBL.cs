using BusinessLayer.Interface;
using RepositoryLayer;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRL repositoryLayer;

        public EmployeeBL(IEmployeeRL repositoryLayer)
        {
            this.repositoryLayer = repositoryLayer;
        }

        public Employee AddEmployee(Employee employee)
        {
            return this.repositoryLayer.AddEmployee(employee);
        }

        public bool DeleteEmployeeById(string id)
        {
            return this.repositoryLayer.DeleteEmployeeById(id);
        }

        public bool EditEmployeeDetails(string id, Employee employee)
        {
            return this.repositoryLayer.EditEmployeeDetails(id,employee);
        }

        public List<Employee> GetEmployeeDetails()
        {
            return this.repositoryLayer.GetEmployeeDetails();
        }
    }
}
