using AnimalCenterAPI.Data;
using AnimalCenterAPI.Repository.Implimentations;
using AnimalCenterAPI.Repository.Interfaces;
using AnimalCenterAPI.Services.Implimentations;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AnimalAppDbContext>(options =>
                options.UseSqlServer(connString));

            // Depedency Injection
            builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
            builder.Services.AddScoped<IAnimalService, AnimalService>();

            builder.Services.AddScoped<IAnimalDeleteRepo, AnimalDeleteRepo>();

            builder.Services.AddScoped<IGetAnimalByIdSer, GetAnimalByIdSer>();
            //builder.Services.AddScoped<IGetAnimalById, GetAnimalById>();

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddScoped<IGetUserByIdSer, GetUserByIdSer>();

            builder.Services.AddScoped<IAppTaskService, AppTaskService>();
            builder.Services.AddScoped<IAppTaskRepository, AppTaskRepository>();

            builder.Services.AddScoped<IGetAppTaskByIdSer, GetAppTaskByIdSer>();

            builder.Services.AddScoped<IAnimalToUpdateSer ,AnimalToUpdateSer>();

            builder.Services.AddScoped<IAppTaskToUpdateSer, AppTaskToUpdateSer>();

            builder.Services.AddScoped<IAnimalTaskRepository ,AnimalTaskRepository>();
            builder.Services.AddScoped<IAnimalTaskService, AnimalTaskService>();

            builder.Services.AddScoped<IGetAnimalTaskByIdSer, GetAnimalTaskByIdSer>();

            builder.Services.AddScoped<IAnimalTaskToUpdate, AnimalTaskToUpdate>();


            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
        
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AnimalCenterAPI v1"));

            app.MapControllers();

            app.Run();
        }
    }
}
           
