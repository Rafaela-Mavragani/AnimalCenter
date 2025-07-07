using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IAnimalTaskRepository
    {
    AnimalTask AnimalTaskMappper(AnimalTaskDTO animalTaskDto);
     AnimalTask AnimalTaskToDelete(AnimalTaskDTO animalTaskDto);
      AnimalTask  AnimalTaskToUpdateID(AnimalTaskUpdateDto animalTaskToUpdateDto);
    }
}
