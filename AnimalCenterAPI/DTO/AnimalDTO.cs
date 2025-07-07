using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AnimalDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "The name of the Animal should be between 2 and 20 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The species of the Animal should be between 3 and 50 characters.")]
        public string Species { get; set; } = string.Empty;

        [Required]
        [Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
        public int Age { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "The gender of the Animal should be between 3 and 10 characters.")]
        public string Gender { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "The description of the Animal should not exceed 50 characters.")]
        public string? Description { get; set; }

        [StringLength(50, ErrorMessage = "The status of the Animal should not exceed 50 characters.")]
        public string? Status { get; set; }
    }
}