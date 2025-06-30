namespace AnimalCenterAPI.Data
{
    public class AnimalTask : BaseEntity
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } // Foreign key for Animal
        public Animal Animal { get; set; } = null!; 
        public AppTask AppTask { get; set; } = null!;
        public int AppTaskId { get; set; } // Foreign key for Task
        public bool IsCompleted { get; set; } = false;


    }
}
