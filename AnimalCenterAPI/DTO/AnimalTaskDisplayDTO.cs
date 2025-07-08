namespace AnimalCenterAPI.DTO
{
    public class AnimalTaskDisplayDTO
    {
        public int Id { get; set; }  // AnimalTask.Id
        public string AnimalName { get; set; } = string.Empty;
        public string TaskName { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending";
    }
}
