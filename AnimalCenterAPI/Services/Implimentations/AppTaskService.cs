using AnimalCenterAPI.Data;
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
    }
}
