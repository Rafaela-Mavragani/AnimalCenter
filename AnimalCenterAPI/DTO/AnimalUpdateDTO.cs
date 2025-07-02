using System.ComponentModel.DataAnnotations;

namespace AnimalCenterAPI.DTO
{
    public class AnimalUpdateDTO
    {
        [Required]
        public int Age { get; set; }
        [StringLength(50, ErrorMessage = "The description of the Animal should not exceed 50 characters.")]
        public string? Description { get; set; }

        [StringLength(50, ErrorMessage = "The status of the Animal should not exceed 50 characters.")]
        public string? Status { get; set; }

    }
}
