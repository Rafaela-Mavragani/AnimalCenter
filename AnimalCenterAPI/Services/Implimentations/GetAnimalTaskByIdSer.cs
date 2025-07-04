using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class GetAnimalTaskByIdSer(AnimalAppDbContext context) : IGetAnimalTaskByIdSer
    {
        readonly AnimalAppDbContext _context = context;

        public async Task<AnimalTask?> GetAnimalTaskByIdAsync(int id)
        {
            return await context.AnimalTasks.FindAsync(id);
        }
    }
    
    
}
