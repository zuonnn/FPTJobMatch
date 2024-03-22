namespace FPTJobMatch.Models
{
    public class Employer : User
    {
        public required string EmployerFullName { get; set; }
        public required string EmployerPhoneNumber { get; set; }
        public required string EmployerEmail { get; set; }
    }
}
