namespace AnimalCenterAPI.Data
{
    public class BaseEntity
    {
        public DateTime InsertedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = null;
    }
}
