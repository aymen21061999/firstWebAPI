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
    }
}
