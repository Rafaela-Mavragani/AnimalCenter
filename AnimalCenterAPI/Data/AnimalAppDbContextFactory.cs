using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AnimalCenterAPI.Data;

namespace AnimalCenterAPI
{
    public class AnimalAppDbContextFactory : IDesignTimeDbContextFactory<AnimalAppDbContext>
    {
        public AnimalAppDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Read the connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");


            var optionsBuilder = new DbContextOptionsBuilder<AnimalAppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AnimalAppDbContext(optionsBuilder.Options);
        }
    }
}
