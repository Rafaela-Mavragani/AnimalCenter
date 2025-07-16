using System.ComponentModel.DataAnnotations;

namespace AnimalCenterAPI.DTO
{
    public class LoginDTO
    {
        //[StringLength(50, MinimumLength = 2, ErrorMessage = "Username should be between 2 and 50 characters.")]
        public string? UserName { get; set; }
        //[StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters.")]
        //[RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W).{8,}$",
        //        ErrorMessage = "Password must contain at least one uppercase letter, " +
        //        "one lowercase letter, one digit, and one special character.")]
        public string? Password { get; set; }
    }
}
