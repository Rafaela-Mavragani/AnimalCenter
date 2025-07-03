using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class AnimalDeleteRepo : IAnimalDeleteRepo
    {
        public Animal AnimalToDelete(AnimalDTO animalDto)
        {
            return new Animal
            {
               Id = animalDto.Id,
             
            };
        }
    }
}