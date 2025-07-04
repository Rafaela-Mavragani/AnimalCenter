using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IGetAnimalTaskByIdSer
    {
        Task<AnimalTask?> GetAnimalTaskByIdAsync(int id);
    }
}
