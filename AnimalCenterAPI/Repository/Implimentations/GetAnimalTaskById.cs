using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class GetAnimalTaskById : IAnimalTaskRepository
    {
        public AnimalTask AnimalTaskMappper(AnimalTaskDTO animalTaskDto)
        {
            return new AnimalTask
            {
                Id = animalTaskDto.Id,
                AnimalId = animalTaskDto.AnimalId,
                AppTaskId = animalTaskDto.AppTaskId,
                IsCompleted = animalTaskDto.IsCompleted,


            };


         }
    }
}
