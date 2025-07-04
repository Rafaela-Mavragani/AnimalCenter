using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AnimalTaskToUpdate(AnimalAppDbContext context) : IAnimalTaskToUpdate
    {
        readonly AnimalAppDbContext _context = context;
        public  async  Task<bool> UpdateAnimalTaskAsync(int id, AnimalTaskUpdateDto dto)
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
    }
}
