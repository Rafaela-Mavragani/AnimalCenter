using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;

namespace AnimalCenterAPI.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        public Animal AnimalMappper(AnimalDTO animalDto)
        {
            return new Animal
            {
                Name = animalDto.Name,
                Species = animalDto.Species,
                Age = animalDto.Age,
                Gender = animalDto.Gender,
                Description = animalDto.Description,
                Status = animalDto.Status,
            };
        }
    }
}