using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class GetAppTaskByIdSer(AnimalAppDbContext context) : IGetAppTaskByIdSer
    {
        public async Task<AppTask?> GetAppTaskByIdAsync(int id)
        {
            var appTask = await context.AppTasks.FindAsync(id);
            return appTask; 
        }
    }
}
