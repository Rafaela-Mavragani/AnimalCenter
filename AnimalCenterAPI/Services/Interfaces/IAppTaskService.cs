        using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAppTaskService
    {
        Task<AppTask> CreateNewAppTaskAsync(AppTask AppTask);
        Task<bool> UpdateAppTaskAsync(int id, AppTaskUpdateDTO dto);
        Task<AppTask?> GetAppTaskByIdAsync(int id);
        Task<bool> DeleteAsync(int id);   
    }
}

