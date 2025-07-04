namespace AnimalCenterAPI.DTO
{
    public class AppTaskUpdateDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int UserId { get; set; }
    }
}
