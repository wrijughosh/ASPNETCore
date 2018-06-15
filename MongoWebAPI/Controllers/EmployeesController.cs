
namespace MongoWebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MongoWebAPI.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        [HttpPost]
        public void Post()
        {
            _employeeRepository.AddEmployee(new Employee
            {
                FullName = "Wriju"
            });

            _employeeRepository.AddEmployee(new Employee
            {
                FullName = "Wrishika"
            });

            _employeeRepository.AddEmployee(new Employee
            {
                FullName = "Writam"
            });
        }

    }
}