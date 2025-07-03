using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Implimentations;
using AnimalCenterAPI.Repository.Interfaces;
using AnimalCenterAPI.Services.Implimentations;
using AnimalCenterAPI.Services.Interfaces;
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
            var appTask = await _context.AppTasks.FindAsync(id);

            if (appTask == null)
            {
                return NotFound();
            }

            return appTask;
        }

        // PUT: api/AppTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppTask(int id, AppTask appTask)
        {
            if (id != appTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(appTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppTaskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

      

        [HttpPost]
        public async Task<ActionResult<AppTask>> PostAppTask(AppTaskDTO appTaskDTO) 
        {
            
            AppTask appTask = await _appTaskService.CreateNewAppTaskAsync(_appTaskRepository.AppTaskMappper(appTaskDTO));

            
            return CreatedAtAction("GetAppTask", new { id = appTask.Id }, appTask);
        }

       
        private bool AppTaskExists(int id)
        {
            return _context.AppTasks.Any(e => e.Id == id);
        }
    }
}
