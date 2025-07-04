using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAnimalTaskService
    {
        public Task<AnimalTask> CreateNewAnimalTaskAsync(AnimalTask AnimalTask);
    }
}
