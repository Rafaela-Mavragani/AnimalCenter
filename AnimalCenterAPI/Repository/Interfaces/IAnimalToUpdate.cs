using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IAnimalToUpdate
    {
        Task<bool> UpdateAsync(int id, Animal updatedAnimal);
    }
}
