using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AppTaskUpdateDTO
    {
        [Required(ErrorMessage = " The field is required.")]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }
        [Required]
        [NotNull]
        public int UserId { get; set; }
    }
}
