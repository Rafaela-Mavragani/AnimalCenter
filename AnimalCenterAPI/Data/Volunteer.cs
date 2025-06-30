using AnimalCenterAPI.Enums;
using System.Security.Cryptography.X509Certificates;

namespace AnimalCenterAPI.Data
{
    public class Volunteer : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Age { get; set; }
        public UserRole UserRole { get; set; }
        public string? PhoneNumber { get; set; }
        public int UserId { get; set; } // Foreign key for User
        public User User { get; set; } = null!; // Navigation property for User


    }
}
