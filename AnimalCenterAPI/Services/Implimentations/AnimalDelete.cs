using AnimalCenterAPI.Data;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AnimalDelete : IAnimalDelete
    {
        private readonly AnimalAppDbContext _context;

        public AnimalDelete(AnimalAppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null) return false;

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
            return true;
        }

    }    }
