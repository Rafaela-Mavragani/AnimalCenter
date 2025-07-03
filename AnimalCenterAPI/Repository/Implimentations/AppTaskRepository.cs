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
    }

}
    

