using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
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
    public class AnimalTasksController(IAnimalTaskRepository animalTaskRepository , IAnimalTaskService animalTaskService , AnimalAppDbContext context, IGetAnimalTaskByIdSer getAnimalTaskByIdSer , IAnimalTaskToUpdate animalTaskToUpdate) : ControllerBase
    {
        readonly AnimalAppDbContext _context = context ;
        readonly IAnimalTaskRepository _animalTaskRepository = animalTaskRepository;    
        readonly IAnimalTaskService _animalTaskService = animalTaskService;
        readonly IGetAnimalTaskByIdSer _getAnimalTaskByIdSer = getAnimalTaskByIdSer;
        readonly IAnimalTaskToUpdate _animalTaskUpdateService = animalTaskToUpdate;



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
            var animalTaskDto = await _getAnimalTaskByIdSer.GetAnimalTaskByIdAsync(id);

            if (animalTaskDto == null)
            {
                return NotFound();
            }

            return Ok(animalTaskDto);
        }

        // PUT: api/AnimalTasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimalTask(int id, AnimalTaskUpdateDto dto)
        {
        
            var updated = await _animalTaskUpdateService.UpdateAnimalTaskAsync(id, dto);
            //var appTaskExists = await _context.AppTasks.AnyAsync(x => x.Id == dto.AppTaskId);
            //var animalExists = await _context.Animals.AnyAsync(x => x.Id == dto.AnimalId);
            //if (!appTaskExists || !animalExists)

                if (!updated)
                return NotFound();

            return NoContent();
        }

        // Fix the type name in the method signature
        [HttpPost]
        public async Task<ActionResult<AnimalTask>> PostAnimalTask(AnimalTaskDTO AnimalTaskDTO) 
        {
            AnimalTask animalTask = await _animalTaskService.CreateNewAnimalTaskAsync(_animalTaskRepository.AnimalTaskMappper(AnimalTaskDTO));

            return CreatedAtAction("GetAnimalTask", new { id = animalTask.Id }, animalTask);
        }


        private bool AnimalTaskExists(int id)
        {
            return _context.AnimalTasks.Any(e => e.Id == id);
        }
    }
}
