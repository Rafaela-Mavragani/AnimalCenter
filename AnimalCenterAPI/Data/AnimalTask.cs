namespace AnimalCenterAPI.Data
{
    public class AnimalTask : BaseEntity
    {
        public int Id { get; set; }
        public int AnimalId { get; set; } // Foreign key for Animal
        public Animal? Animal { get; set; } 
        public AppTask? AppTask { get; set; }
        public int AppTaskId { get; set; } 
        public bool IsCompleted { get; set; } = false;

     }
}
