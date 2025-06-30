namespace AnimalCenterAPI.Data
{
    public class Animal : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Species { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string? Description { get; set; }
        public string? Status { get; set; }
        public ICollection<AnimalTask> AnimalTasks { get; set; } = new HashSet<AnimalTask>(); // Navigation property for AnimalTasks

    }
}
