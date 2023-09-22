namespace firstMVCwebAPI.Models
{
    public class RepositoryEmployee
    {
        public NorthwindContext _context;
        public RepositoryEmployee (NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            _context.Employees.Attach(updatedEmployee);
            _context.SaveChanges();
            return updatedEmployee;
        }
       
        public List<Employee> AddEmployees(Employee emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return _context.Employees.ToList();
        }
        public Employee DeleteEmployees(Employee emp)
        {
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return emp;
        }
    }
}
