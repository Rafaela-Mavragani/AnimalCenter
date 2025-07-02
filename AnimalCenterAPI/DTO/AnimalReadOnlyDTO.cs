namespace AnimalCenterAPI.DTO
{
    public class AnimalReadOnlyDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; } 
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
