using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IAnimalRepository
    {
        Animal AnimalMappper(AnimalDTO animalDto);
    }
}
