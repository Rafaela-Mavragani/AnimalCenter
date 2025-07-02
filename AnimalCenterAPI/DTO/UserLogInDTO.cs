using System.ComponentModel.DataAnnotations;

namespace AnimalCenterAPI.DTO
{
    public class UserLogInDTO
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 50 characters.")]
        [Required]
        public string? Username { get; set; }

        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters.")]
        [RegularExpression(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W)^.{8,}$",
            ErrorMessage = "Password must contain at least one uppercase, one lowercase, " +
            "one digit, and one special character")]
        [Required]
        public string? Password { get; set; }
    }
}
