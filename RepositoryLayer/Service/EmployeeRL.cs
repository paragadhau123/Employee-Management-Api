using CommonLayer.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmployeeRL
    {
        private readonly IMongoCollection<EmployeeResponseModel> _Employee;

        public EmployeeRepositoryLayer(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            this._Employee = database.GetCollection<Employee>(settings.EmployeeCollectionName);
        }
    }
}
