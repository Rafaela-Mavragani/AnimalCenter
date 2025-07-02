using AnimalCenterAPI.Enums;

namespace AnimalCenterAPI.DTO
{
    public class UserReadOnlyDTO
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public UserRole? UserRole { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
