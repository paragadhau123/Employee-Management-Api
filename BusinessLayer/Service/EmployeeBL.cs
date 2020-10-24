using BusinessLayer.Interface;
using CommonLayer.Model;
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

        public Employee AddEmployee(EmployeeModel employee)
        {
            return this.repositoryLayer.AddEmployee(employee);
        }

        List<Employee> IEmployeeBL.GetEmployeeDetails()
        {
           return this.repositoryLayer.GetEmployeeDetails();
        }
    }
}
