using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AnimalTaskUpdateDto
    {
        public bool IsCompleted { get; set; }

        public int AnimalId { get; set; }

        public int AppTaskId { get; set; }
    }
}
