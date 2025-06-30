using AnimalCenterAPI.Enums;

namespace AnimalCenterAPI.Data
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public UserRole UserRole { get; set; }  
       public Volunteer? Volunteer { get; set; } // Navigation property for Volunteer
        public ICollection<AppTask> AppTasks { get; set; } = new HashSet<AppTask>();
    }
}
