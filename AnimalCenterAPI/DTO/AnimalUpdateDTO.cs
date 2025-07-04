using System.ComponentModel.DataAnnotations;

namespace AnimalCenterAPI.DTO
{
    public class AnimalUpdateDTO
    {
        public string Name { get; set; } = null!;
        public string Species { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string? Description { get; set; }
        public string? Status { get; set; }
       

    }
}
