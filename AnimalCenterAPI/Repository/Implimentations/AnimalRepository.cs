using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
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