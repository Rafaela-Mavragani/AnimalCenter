using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AnimalTaskService(AnimalAppDbContext context) : IAnimalTaskService
    {
        readonly AnimalAppDbContext _context = context;

        public async Task<AnimalTask> CreateNewAnimalTaskAsync(AnimalTask AnimalTask)
        {
            context.AnimalTasks.Add(AnimalTask);
            await _context.SaveChangesAsync(); ;
            return AnimalTask;
        }
    }
}
