using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoWebAPI.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();

        // add new note document
        Task AddEmployee(Employee item);
    }
}
