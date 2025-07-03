using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;
using AnimalCenterAPI.Services.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class GetAnimalByID : AnimalRepository
    {
        public Animal AnimalByID(AnimalReadOnlyDTO animalReadOnlyDto)
        {
            return new Animal
            {
                Id = animalReadOnlyDto.Id,
                Name = animalReadOnlyDto.Name ?? string.Empty,
                Species = animalReadOnlyDto.Species ?? string.Empty,
                Age = animalReadOnlyDto.Age,
                Gender = animalReadOnlyDto.Gender ?? string.Empty,
                Description = animalReadOnlyDto.Description,
                Status = animalReadOnlyDto.Status,
                InsertedAt = animalReadOnlyDto.InsertedAt,
                UpdatedAt = animalReadOnlyDto.ModifiedAt
            };
        }


    }


}

