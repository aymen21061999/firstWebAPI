using Microsoft.AspNetCore.Http;
using firstMVCwebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [HttpGet("/AllEmployees")]

        public IEnumerable<EmpViewModel> GetEmployee()
        {
            List<Employee> employees = _context.GetEmployees();
            var emplist = (
                from emp in employees
                select new EmpViewModel()
                {
                    EmpId = emp.EmployeeId,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Title = emp.Title,
                    BirthDate = emp.BirthDate,
                    HireDate = emp.HireDate,
                    City = emp.City,
                    ReportsTo = emp.ReportsTo
                }
                ).ToList();
            return emplist;
        }
        [HttpPut]
        public List<Employee> AddEmployee(Employee emp)
        {
            return _context.AddEmployees(emp);
        }
        [HttpPost]
        public Employee UpdateEmployee(int id, [FromBody] Employee emp)
        {
            emp.EmployeeId = id;
            Employee savedemp = _context.UpdateEmployee(emp);
            return savedemp;

        }
        [HttpDelete]
        public Employee RemoveEmployee(int id, [FromBody] Employee emp)
        {
            emp.EmployeeId = id;
            return _context.DeleteEmployees(emp);
        }

        

    }
    

}

