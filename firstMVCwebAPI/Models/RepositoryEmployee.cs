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
    }
}
