using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IGetAppTaskByIdSer
    {
        Task<AppTask?> GetAppTaskByIdAsync(int id);
    }
}
