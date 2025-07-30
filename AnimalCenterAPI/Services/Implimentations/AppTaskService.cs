using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AppTaskService(AnimalAppDbContext context) : IAppTaskService
    {
    

        readonly AnimalAppDbContext _context = context;

        public async Task<AppTask> CreateNewAppTaskAsync(AppTask appTask)
        {
            _context.AppTasks.Add(appTask); 
            await _context.SaveChangesAsync();
            return appTask;
        }
        public async Task<bool> UpdateAppTaskAsync(int id, AppTaskUpdateDTO dto)
        {
            var appTask = await _context.AppTasks.FindAsync(id);
            if (appTask == null)
                return false;

            appTask.Name = dto.Name;
            appTask.Description = dto.Description;
            appTask.UserId = dto.UserId;
            appTask.AnimalTaskId = dto.AnimalTaskId;
            appTask.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<AppTask?> GetAppTaskByIdAsync(int id)
        {
            var appTask = await context.AppTasks.FindAsync(id);
            return appTask;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var appTask = await _context.AppTasks.FindAsync(id);
            if (appTask == null) return false;

            _context.AppTasks.Remove(appTask);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
