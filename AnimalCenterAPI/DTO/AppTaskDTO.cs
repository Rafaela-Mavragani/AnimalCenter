using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterApp.DTO
{
    public class AppTaskDTO
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
        [Required (ErrorMessage = " The field is required.") ]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        [NotNull]
        public int UserId { get; set; }
    }

}

