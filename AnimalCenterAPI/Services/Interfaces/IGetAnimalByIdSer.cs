using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IGetAnimalByIdSer
    {
        Task<Animal?> GetAnimalByIdAsync(int id);
    }
}
