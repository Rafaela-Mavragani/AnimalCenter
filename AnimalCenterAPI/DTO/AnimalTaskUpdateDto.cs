using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AnimalTaskUpdateDto
    {
        public bool IsCompleted { get; set; }

        [Required]
        [NotNull]
        public int AnimalId { get; set; }


        [Required]
        [NotNull]
        public int AppTaskId { get; set; }
    }
}
