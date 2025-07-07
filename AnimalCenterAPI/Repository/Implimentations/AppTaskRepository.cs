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
                UserId = AppTaskDTO.UserId
            };

        }


        public AppTask AppTask(AppTaskUpdateDTO AppTaskToUpDateDTO)
        {
            return new AppTask
            {

                Name = AppTaskToUpDateDTO.Name ?? string.Empty,
                Description = AppTaskToUpDateDTO.Description ?? string.Empty,
                UserId = AppTaskToUpDateDTO.UserId
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
    

