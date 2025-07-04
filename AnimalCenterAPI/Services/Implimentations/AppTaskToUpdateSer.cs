using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AppTaskToUpdateSer : IAppTaskToUpdateSer
    {
        private readonly AnimalAppDbContext _context;

        public AppTaskToUpdateSer(AnimalAppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdateAppTaskAsync(int id, AppTaskUpdateDTO dto)
        {
            var appTask = await _context.AppTasks.FindAsync(id);
            if (appTask == null)
                return false;

            appTask.Name = dto.Name;
            appTask.Description = dto.Description;
            appTask.UserId = dto.UserId;
            appTask.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}

