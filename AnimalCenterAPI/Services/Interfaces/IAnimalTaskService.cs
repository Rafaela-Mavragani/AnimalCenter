using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAnimalTaskService
    {
        public Task<AnimalTask> CreateNewAnimalTaskAsync(AnimalTask AnimalTask);
        Task<bool> UpdateAnimalTaskAsync(int id, AnimalTaskUpdateDto dto);
        Task<AnimalTask?> GetAnimalTaskByIdAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
}
