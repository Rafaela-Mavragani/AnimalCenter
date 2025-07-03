using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Services.Interfaces
{
    public interface IAppTaskService
    {
        Task<AppTask> CreateNewAppTaskAsync(AppTask AppTask);
    }
}
