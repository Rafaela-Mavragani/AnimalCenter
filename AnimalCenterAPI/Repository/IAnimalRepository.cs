using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository
{
    public interface IAnimalRepository
    {
        Animal AnimalMappper(AnimalDTO animalDto);
    }
}
