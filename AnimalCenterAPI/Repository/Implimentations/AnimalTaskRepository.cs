﻿using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;

namespace AnimalCenterAPI.Repository.Implimentations
{
    public class AnimalTaskRepository : IAnimalTaskRepository
    {
        public AnimalTask AnimalTaskMappper(AnimalTaskDTO animalTaskDto)
        {
            return new AnimalTask
            {
                Id = animalTaskDto.Id,
                AnimalId = animalTaskDto.AnimalId,
                AppTaskId = animalTaskDto.AppTaskId,
                IsCompleted = animalTaskDto.IsCompleted,
            };
        }

        public AnimalTask AnimalTaskToDelete(AnimalTaskDTO animalTaskDto)
        {
            return new AnimalTask
            {
                Id = animalTaskDto.Id
            };
        }

        public AnimalTask AnimalTaskToUpdateID(AnimalTaskUpdateDto animalTaskToUpdateDto)
        {
            return new AnimalTask
            {
                AnimalId = animalTaskToUpdateDto.AnimalId,
                AppTaskId = animalTaskToUpdateDto.AppTaskId,
                IsCompleted = animalTaskToUpdateDto.IsCompleted

            };
        }


    }
}
