namespace AnimalCenterAPI.Data
{
    public class AppTask : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } 
        public int AnimalTaskId { get; set; } // Foreign key for AnimalTask
        public AnimalTask AnimalTask { get; set; } = null!;
        public int UserId { get; set; } // Foreign key for User
        public User User { get; set; } = null!;
    }
}

