namespace AnimalCenterAPI.DTO
{
    public class AnimalTaskReadDto
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int AppTaskId { get; set; }
        public bool IsCompleted { get; set; }
    }
}
