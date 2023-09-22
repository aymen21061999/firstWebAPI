using firstMVCwebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstMVCwebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private RepositoryEmployee _context;
        public EmployeeController(RepositoryEmployee context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Employee> AllEmployee()
        {
            return _context.GetEmployees();
        }
        [HttpPost]
        public Employee UpdateEmployee(int id, [FromBody] Employee emp)
        {
            emp.EmployeeId = id;
            Employee savedemp = _context.UpdateEmployee(emp);
            return savedemp;

        }
    }
}
