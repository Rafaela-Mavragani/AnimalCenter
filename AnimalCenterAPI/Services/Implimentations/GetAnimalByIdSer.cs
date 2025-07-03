using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class GetAnimalByIdSer(AnimalAppDbContext context) : IGetAnimalByIdSer
    {
        public async Task<Animal?> GetAnimalByIdAsync(int id)
        {
            return await context.Animals.FindAsync(id);
        }
    }
}
