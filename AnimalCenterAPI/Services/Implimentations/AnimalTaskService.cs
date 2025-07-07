using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
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
        public async  Task<bool> UpdateAnimalTaskAsync(int id, AnimalTaskUpdateDto dto)
        {
            var animalTask = await _context.AnimalTasks.FindAsync(id);
            if (animalTask == null)
                return false;

            animalTask.AppTaskId = dto.AppTaskId;
            animalTask.AnimalId = dto.AnimalId;
            animalTask.IsCompleted = dto.IsCompleted;
            animalTask.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<AnimalTask?> GetAnimalTaskByIdAsync(int id)
        {
            return await _context.AnimalTasks.FindAsync(id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var animalTask = await _context.AnimalTasks.FindAsync(id);
            if (animalTask == null) return false;

            _context.AnimalTasks.Remove(animalTask);
            await _context.SaveChangesAsync();
            return true;
        }

    }


}

