using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IAppTaskRepository
    {
        AppTask AppTaskMappper(AppTaskDTO AppTaskDTO);
        AppTask AppTask(AppTaskUpdateDTO AppTaskToUpDateDTO);
        AppTask AppTaskToDelete(AppTaskDTO AppTaskDto);
      
    }
}
