using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class AppTaskRepository : IAppTaskRepository
    {
        public AppTask AppTaskMappper(AppTaskDTO AppTaskDTO)
        {

            return new AppTask
            {
                Id = AppTaskDTO.Id,
                Name = AppTaskDTO.Name ?? string.Empty,
                Description = AppTaskDTO.Description ?? string.Empty,
                UserId = AppTaskDTO.UserId,
                AnimalTaskId = AppTaskDTO.AnimalTaskId
            };

        }


        public AppTask AppTask(AppTaskUpdateDTO AppTaskToUpDateDTO)
        {
            return new AppTask
            {

                Name = AppTaskToUpDateDTO.Name ?? string.Empty,
                Description = AppTaskToUpDateDTO.Description ?? string.Empty,
                UserId = AppTaskToUpDateDTO.UserId,
                AnimalTaskId = AppTaskToUpDateDTO.AnimalTaskId,
            };
        }
        public AppTask AppTaskToDelete(AppTaskDTO AppTaskDto)
        {
            return new AppTask
            {
                Id = AppTaskDto.Id
            };
        }




    }
}
    

