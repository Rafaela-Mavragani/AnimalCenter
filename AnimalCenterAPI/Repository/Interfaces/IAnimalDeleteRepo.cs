using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IAnimalDeleteRepo
    {
        public Animal AnimalToDelete(AnimalDTO animalDto);
    };
}

