using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterApp.DTO
{
    public class AnimalDTO

    {
        [Required]
        [NotNull]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "The name of th Animal should be between 2 and 20 characters.")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The specie of th Animal should be between 3 and 50 characters.")]
        public string Species { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Τηε λενγθ of the Animal should be between 3 and 10 characters.")]
        public string Gender { get; set; } = null!;

        [StringLength(50, ErrorMessage = "The description of the Animal should not exceed 50 characters.")]
        public string? Description { get; set; }

        [StringLength(50, ErrorMessage = "The status of the Animal should not exceed 50 characters.")]
        public string? Status { get; set; }
    }
}
