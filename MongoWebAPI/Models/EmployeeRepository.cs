using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoWebAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HRContext _context = null;

        public EmployeeRepository(IOptions<Settings> settings)
        {
            _context = new HRContext(settings);
        }
        
        async Task IEmployeeRepository.AddEmployee(Employee item)
        {
            try
            {
                await _context.Employees.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

        async Task<IEnumerable<Employee>> IEmployeeRepository.GetAllEmployees()
        {
            try
            {
                return await _context.Employees.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
    }
}
