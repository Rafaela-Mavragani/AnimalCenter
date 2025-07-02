using AnimalCenterAPI.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterApp.DTO
{
    public class VolunteerDTO
    {

        [NotNull]
        [Required]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Firstname should be between 3 and 50 characters.")]
        
        public string? FirstName { get; set; } 

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Lastname should be between 3 and 50 characters.")]
        public string? LastName { get; set; }
        
        public string? Age { get; set; }
        public string? PhoneNumber { get; set; }
        public UserRole? UserRole { get; set; } 


    }
}
