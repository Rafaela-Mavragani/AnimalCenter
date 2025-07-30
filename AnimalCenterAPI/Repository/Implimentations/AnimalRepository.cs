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
        public Animal AnimalToDelete(AnimalDTO animalDto)
        {
            return new Animal
            {
                Id = animalDto.Id,
            };
        }

        public Animal AnimalByID(AnimalToUpdateDTO animalToUpdateDto)
        {
            return new Animal
            {
                Id = animalToUpdateDto.Id,
                Name = animalToUpdateDto.Name ?? string.Empty,
                Species = animalToUpdateDto.Species ?? string.Empty,
                Age = animalToUpdateDto.Age,
                Gender = animalToUpdateDto.Gender ?? string.Empty,
                Description = animalToUpdateDto.Description,
                Status = animalToUpdateDto.Status,
                InsertedAt = animalToUpdateDto.InsertedAt,
                UpdatedAt = animalToUpdateDto.ModifiedAt
            };
        }
    }
    
}