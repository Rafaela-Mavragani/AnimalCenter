using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AnimalTaskDTO
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int AppTaskId { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
