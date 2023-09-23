using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;

namespace firstMVCwebAPI.Models
{
    
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
        public int AddEmployees(Employee emp)
        {
            Employee? foundEmp = _context.Employees.Find(emp.EmployeeId);
            if (foundEmp != null)
            {
                throw new Exception("Failed to add Employess.Duplicate Id");
            }
            EntityState es = _context.Entry(emp).State;
            Console.WriteLine($"EntityState B4Add:{es.GetDisplayName()}");
            _context.Employees.Add(emp);
            es = _context.Entry(emp).State;
            Console.WriteLine($"EntityState AfterAdd:{es.GetDisplayName()}");
            int result = _context.SaveChanges();
            es = _context.Entry(emp).State;
            Console.WriteLine($"EntityState After SaveChanges:{es.GetDisplayName()}");
            return result;

            //_context.Employees.Add(emp);
            //_context.SaveChanges();
            //return emp;
        }
        public Employee FindEmployeeById(int id)
        {
            Employee employee = _context.Employees.Find(id);
            return employee;
        }
        public int UpdateEmployee(Employee updatedEmployee)
        {
            EntityState es = _context.Entry(updatedEmployee).State;
            Console.WriteLine($"EntityState B4Add:{es.GetDisplayName()}");
            _context.Employees.Add(updatedEmployee);
            es = _context.Entry(updatedEmployee).State;
            Console.WriteLine($"EntityState AfterAdd:{es.GetDisplayName()}");
            int result = _context.SaveChanges();
            es = _context.Entry(updatedEmployee).State;
            Console.WriteLine($"EntityState After SaveChanges:{es.GetDisplayName()}");
            return result;
            //_context.Employees.Update(updatedEmployee);
            //_context.SaveChanges();
            //return updatedEmployee;
        }
        public void DeleteEmployee(int employeeId)
        {
            var employeeToDelete = _context.Employees.Find(employeeId);

            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                _context.SaveChanges();

            }
            else
            {
                Console.WriteLine("Employee not exists");
            }
        }
    }
}
