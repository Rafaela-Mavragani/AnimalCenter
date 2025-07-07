using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository.Interfaces
{
    public interface IAnimalRepository
    {
        Animal AnimalMappper(AnimalDTO animalDto);
        public Animal AnimalToDelete(AnimalDTO animalDto);
        public Animal AnimalByID(AnimalToUpdateDTO animalToUpdateDto);

    }
}
