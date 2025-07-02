using AnimalCenterAPI.Enums;

namespace AnimalCenterApp.DTO
{
    public class VolunteerReadOnlyDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public string? PhoneNumber { get; set; }
        public string? Age { get; set; }
        public UserRole UserRole { get; set; }
        public DateTime InsertedAt { get; set; }
    }
}
