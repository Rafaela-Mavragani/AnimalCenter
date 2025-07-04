using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AnimalToUpdateSer(AnimalAppDbContext context) : IAnimalToUpdateSer
    {
      readonly AnimalAppDbContext _context = context;

 
        public async Task<bool> UpdateAnimalAsync(int id, AnimalUpdateDTO dto)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
                return false;

            // Update the animal properties with the values from the DTO
            animal.Name = dto.Name;
            animal.Species = dto.Species;
            animal.Age = dto.Age;
            animal.Gender = dto.Gender;
            animal.Description = dto.Description;
            animal.Status = dto.Status;

            // Update the UpdatedAt timestamp
            animal.UpdatedAt = DateTime.UtcNow;

            // Save changes to the database
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
           
