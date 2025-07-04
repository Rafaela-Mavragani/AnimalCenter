using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAppTaskToUpdateSer
    {
        Task<bool> UpdateAppTaskAsync(int id, AppTaskUpdateDTO dto);
    }
}
