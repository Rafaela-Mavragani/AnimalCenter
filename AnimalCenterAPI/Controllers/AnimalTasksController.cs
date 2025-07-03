using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalCenterAPI.Data;

namespace AnimalCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalTasksController : ControllerBase
    {
        private readonly AnimalAppDbContext _context;

        public AnimalTasksController(AnimalAppDbContext context)
        {
            _context = context;
        }

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
            var animalTask = await _context.AnimalTasks.FindAsync(id);

            if (animalTask == null)
            {
                return NotFound();
            }

            return animalTask;
        }

        // PUT: api/AnimalTasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimalTask(int id, AnimalTask animalTask)
        {
            if (id != animalTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(animalTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalTaskExists(id))
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

        // POST: api/AnimalTasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AnimalTask>> PostAnimalTask(AnimalTask animalTask)
        {
            _context.AnimalTasks.Add(animalTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimalTask", new { id = animalTask.Id }, animalTask);
        }

        // DELETE: api/AnimalTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalTask(int id)
        {
            var animalTask = await _context.AnimalTasks.FindAsync(id);
            if (animalTask == null)
            {
                return NotFound();
            }

            _context.AnimalTasks.Remove(animalTask);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimalTaskExists(int id)
        {
            return _context.AnimalTasks.Any(e => e.Id == id);
        }
    }
}
