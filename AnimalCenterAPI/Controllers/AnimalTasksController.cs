using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Exceptions;
using AnimalCenterAPI.Repository.Implimentations;
using AnimalCenterAPI.Repository.Interfaces;
using AnimalCenterAPI.Services.Implimentations;
using AnimalCenterAPI.Services.Interfaces;
using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalTasksController(IAnimalTaskRepository animalTaskRepository , IAnimalTaskService animalTaskService , AnimalAppDbContext context) : ControllerBase
    {
        readonly AnimalAppDbContext _context = context ;
        readonly IAnimalTaskRepository _animalTaskRepository = animalTaskRepository;
        readonly IAnimalTaskService _animalTaskService = animalTaskService;



        // GET: api/AnimalTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnimalTask>>> GetAnimalTasks()
        {
            return await _context.AnimalTasks.ToListAsync();
        }

        // GET: api/AnimalTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnimalTask>> GetAnimalTask(int id)
        {
            var animalTaskDto = await _animalTaskService.GetAnimalTaskByIdAsync(id) ?? throw new EntityNotFoundException("AnimalTask", $"with ID: {id}");
            return Ok(animalTaskDto);
        }

        // PUT: api/AnimalTasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimalTask(int id, AnimalTaskUpdateDto dto)
        {
        
            var updated = await _animalTaskService.UpdateAnimalTaskAsync(id, dto);
                if (!updated)
                throw new EntityNotFoundException("AnimalTask", $"with ID: {id}");

            return NoContent();
        }

       
        [HttpPost]
        public async Task<ActionResult<AnimalTask>> PostAnimalTask(AnimalTaskDTO AnimalTaskDTO) 
        {
            bool exists = await _context.AnimalTasks.AnyAsync(x => x.Id == AnimalTaskDTO.Id);

            if (exists)
            {
                throw new EntityAlreadyExistsException("AnimalTask", $"with Id: {AnimalTaskDTO.Id}");
            }
            AnimalTask animalTask = await _animalTaskService.CreateNewAnimalTaskAsync(_animalTaskRepository.AnimalTaskMappper(AnimalTaskDTO));

            return CreatedAtAction("GetAnimalTask", new { id = animalTask.Id }, animalTask);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalTask(int id)
        {
            var deleted = await _animalTaskService.DeleteAsync(id);

            if (!deleted)
                throw new EntityAlreadyExistsException("User", $"with Id: {id}");

            return NoContent();
        }

    }
}

