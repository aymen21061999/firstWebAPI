namespace firstMVCwebAPI.Models
{
    public class EmpViewModel
    {
        public int EmpId{get; set;}
        public string FirstName { get; set;}=String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Title {  get; set;} = String.Empty;
        public DateTime? BirthDate { get; set;}
        public DateTime? HireDate { get; set;}
        public string? City { get; set;}
        public int? ReportsTo {  get; set;}
    }
}
