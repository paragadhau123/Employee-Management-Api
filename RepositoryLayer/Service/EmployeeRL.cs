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

        public List<Employee> GetEmployeeDetails()
        {
            return this._Employee.Find(employee => true).ToList();
        }
    }
}
