using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class EmployeeDatabaseSettings : IEmployeeDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string EmployeeCollectionName { get; set; }


    }

    public interface IEmployeeDatabaseSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }

        string EmployeeCollectionName { get; set; }

    }
}
