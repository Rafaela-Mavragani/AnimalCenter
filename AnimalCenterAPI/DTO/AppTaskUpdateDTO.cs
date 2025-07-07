namespace AnimalCenterAPI.DTO
{
    public class AppTaskUpdateDTO
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int UserId { get; set; }
        public int AnimalTaskId{ get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
