using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AnimalTaskDTO
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
        [Required]
        [NotNull]
        public int AnimalId { get; set; }

        [Required]
        [NotNull]
        public int AppTaskId { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}
