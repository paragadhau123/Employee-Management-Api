using CommonLayer.Model;
using MongoDB.Driver;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmployeeRL:IEmployeeRL
    {
        private readonly IMongoCollection<Employee> _Employee;

        public EmployeeRL(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            this._Employee = database.GetCollection<Employee>(settings.EmployeeCollectionName);
        }

        public Employee AddEmployee(EmployeeModel employee)
        {
            try
            {
                Employee newEmployee = new Employee()
                {
                    EmployeeFirstName = employee.EmployeeFirstName,
                    EmployeeLastName = employee.EmployeeLastName,
                    Email = employee.Email,
                    Password = employee.Password,
                    PhoneNumber = employee.PhoneNumber,
                };
                this._Employee.InsertOne(newEmployee);
                return newEmployee;
            }
            catch
            {
                return null;
            }
        }

        public bool DeleteEmployeeById(string id)
        {
            try
            {
                this._Employee.DeleteOne(employee => employee.Id == id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Employee> GetEmployeeDetails()
        {
            return this._Employee.Find(employee => true).ToList();
        }
    }
}
