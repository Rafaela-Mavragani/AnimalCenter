using AnimalCenterAPI.Enums;

namespace AnimalCenterAPI.Data
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? lastname {  get; set; }  
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public UserRole UserRole { get; set; } 
        public ICollection<AppTask> AppTasks { get; set; } = new HashSet<AppTask>();
    }
}
