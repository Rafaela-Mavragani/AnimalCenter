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
using AnimalCenterAPI.Exceptions; 

namespace AnimalCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppTasksController(AnimalAppDbContext context, IAppTaskRepository appTaskRepository, IAppTaskService appTaskService): ControllerBase
    {
        private readonly AnimalAppDbContext _context = context;
        private readonly IAppTaskRepository _appTaskRepository = appTaskRepository;
        private readonly IAppTaskService _appTaskService = appTaskService;  



        // GET: api/AppTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppTask>>> GetAppTasks()
        {
            return await _context.AppTasks.ToListAsync();
        }

        // GET: api/AppTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppTask>> GetAppTask(int id)
        {
            var appTaskDto = await _appTaskService.GetAppTaskByIdAsync(id) ?? throw new EntityNotFoundException("AppTask", $"with ID: {id}");
            return Ok(appTaskDto);
        }

        // PUT: api/AppTasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppTask(int id, AppTaskUpdateDTO dto)
        {
            var updated = await _appTaskService.UpdateAppTaskAsync(id, dto);

            if (!updated)
            {
                throw new EntityNotFoundException("AppTask", $"with ID: {id}");
            }

            return NoContent();
        }

            [HttpPost]
        public async Task<ActionResult<AppTask>> PostAppTask(AppTaskDTO appTaskDTO) 
        {
            bool exists = await _context.AppTasks.AnyAsync(x => x.Name == appTaskDTO.Name);

            if (exists)
            {
                throw new EntityAlreadyExistsException("AppTask", $"with Name: {appTaskDTO.Name}");
            }

            AppTask appTask = await _appTaskService.CreateNewAppTaskAsync(_appTaskRepository.AppTaskMappper(appTaskDTO));

            
            return CreatedAtAction("GetAppTask", new { id = appTask.Id }, appTask);
        }

        // DELETE: api/AppTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppTask(int id)       
        {               
            var deleted = await _appTaskService.DeleteAsync(id);

            if (!deleted)
                throw new EntityAlreadyExistsException("AppTask", $"with Id: {id}");

            return NoContent();
        }
    }
}
