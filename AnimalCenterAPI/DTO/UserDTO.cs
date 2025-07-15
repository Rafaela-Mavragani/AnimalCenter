using AnimalCenterAPI.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
  public class UserDTO
    // This class is used to transfer user data between the application and the API
  {
     [NotNull]
     public int Id { get; set; }

     [StringLength(50, MinimumLength = 2, ErrorMessage = "Username should be between 2 and 50 characters.")]
     public string? UserName { get; set; }
     [StringLength(50, MinimumLength = 2, ErrorMessage = "Firstname should be between 2 and 50 characters.")]
     public string? firstname { get; set; }
     [StringLength(50, MinimumLength = 2, ErrorMessage = "Lastname should be between 2 and 50 characters.")]
     public string? lastname { get; set; }

    [StringLength(50, ErrorMessage = "Email should not exceed 100 characters.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
     public string? Email { get; set; } 

    [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters.")]
    [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W).{8,}$",
     ErrorMessage = "Password must contain at least one uppercase letter, " +
                    "one lowercase letter, one digit, and one special character.")]
     public string? Password { get; set; }

     [Required]
     public UserRole? UserRole { get; set; } = Enums.UserRole.Volunteer;
    
  }
       
}
