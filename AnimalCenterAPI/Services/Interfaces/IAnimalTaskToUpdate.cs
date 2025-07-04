using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAnimalTaskToUpdate
    {
        Task <bool> UpdateAnimalTaskAsync(int id, AnimalTaskUpdateDto dto);
    }
}
