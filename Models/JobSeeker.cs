namespace FPTJobMatch.Models
{
    public class JobSeeker : User
    {
        public required string JobSeekerFullName { get; set; }
        public required string JobSeekerPhoneNumber { get; set; }
        public required string JobSeekerEmail { get; set; }
        public required string JobSeekerDateOfBirth { get; set; }
        public required Enum.GenderEnum JobSeekerGender { get; set; }
        public Address? Address { get; set; }
    }

    public class Address
    {
        public required string Street { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set; }
    }
}
