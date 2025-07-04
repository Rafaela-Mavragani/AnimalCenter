using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAnimalToUpdateSer
    {
        Task<bool> UpdateAnimalAsync(int id, AnimalUpdateDTO dto);
    }
    
}

