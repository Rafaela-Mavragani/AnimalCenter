using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Services.Implimentations
{
    public class AnimalService(AnimalAppDbContext context) : IAnimalService
    {
        readonly AnimalAppDbContext _context = context;

        public async Task<Animal> CreateNewAnimalAsync(Animal animal)
        {
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();
            return animal;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null) return false;

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
            return true;
        }

             public async Task<Animal?> GetAnimalByIdAsync(int id)
        {
            return await context.Animals.FindAsync(id);
        }
    }




}

