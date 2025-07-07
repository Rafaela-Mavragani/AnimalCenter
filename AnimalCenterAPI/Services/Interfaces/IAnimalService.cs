using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAnimalService
    {
        Task<Animal> CreateNewAnimalAsync(Animal animal);
        Task<bool> DeleteAsync(int id);
        Task<Animal?> GetAnimalByIdAsync(int id);
        Task<bool> UpdateAnimalAsync(int id, AnimalUpdateDTO dto);
    }
}
