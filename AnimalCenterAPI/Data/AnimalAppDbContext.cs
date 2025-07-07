using AnimalCenterAPI.Enums;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Data
{
    public class AnimalAppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<AppTask> AppTasks { get; set; }
        public DbSet<Animal> Animals { get; set; }
      
        public DbSet<AnimalTask> AnimalTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(e => e.InsertedAt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.UpdatedAt)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.UserRole).HasConversion<string>();
                entity.HasIndex(e => e.Email, "IX_Users_Email").IsUnique();
                entity.HasMany(u => u.AppTasks)
                    .WithOne(t => t.User)
                    .HasForeignKey(t => t.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("Animals");
                entity.Property(e => e.InsertedAt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.UpdatedAt)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("GETDATE()");
                entity.HasIndex(e => e.Name, "IX_Animals_Name").IsUnique();
                entity.HasMany(a =>a.AnimalTasks)
                      .WithOne(at => at.Animal)
                      .HasForeignKey(at => at.AnimalId)
                      .OnDelete(DeleteBehavior.Cascade);
                       
            });

            modelBuilder.Entity<AppTask>(entity =>
            {
                entity.ToTable("AppTasks");
                entity.Property(e => e.InsertedAt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.UpdatedAt)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("GETDATE()");
                entity.HasIndex(e => e.Name, "IX_AppTasks_Name").IsUnique();
                entity.HasOne(t => t.AnimalTask)
                    .WithOne(at => at.AppTask)
                   .HasForeignKey<AnimalTask>(at => at.AppTaskId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<AnimalTask>(entity =>
            {
                entity.ToTable("AnimalTasks");
                entity.Property(e => e.InsertedAt)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.UpdatedAt)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("GETDATE()");
                entity.HasOne(at => at.Animal)
                      .WithMany(a => a.AnimalTasks)
                      .HasForeignKey(at => at.AnimalId)
                      .OnDelete(DeleteBehavior.Cascade);

            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Admin",
                lastname = "User",
                UserName = "admin",
                Email = "admin@example.com",
                Password = "12345Aa!", 
                UserRole = (UserRole)1,
                InsertedAt = new DateTime(2025, 01, 01, 0, 0, 0, DateTimeKind.Utc),
                UpdatedAt = null
            });
        }
    }
  
}

