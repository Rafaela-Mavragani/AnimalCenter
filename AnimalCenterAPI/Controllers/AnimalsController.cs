using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Repository.Interfaces;
using AnimalCenterAPI.Services.Implimentations;
using AnimalCenterAPI.Services.Interfaces;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimalCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController(AnimalAppDbContext context,IAnimalService animalService ,IAnimalDelete animalDelete , IGetAnimalByIdSer getAnimalByIdSer, IAnimalToUpdateSer animalToUpdateSer, IAnimalRepository animalRepository) : ControllerBase
    {
        private readonly AnimalAppDbContext _context = context;
    
        private readonly IAnimalService _animalService = animalService;
        private readonly IAnimalDelete _animalDelete = animalDelete;
        private readonly IGetAnimalByIdSer _getAnimalByIdSer = getAnimalByIdSer;
        private readonly IAnimalToUpdateSer _animalToUpdateSer = animalToUpdateSer;
        private readonly IAnimalRepository _animalRepository = animalRepository;

        // GET: api/Animals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animal>>> GetAnimals()
        {
            return await _context.Animals.ToListAsync();
        }

        // GET: api/Animals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Animal>> GetAnimal(int id)
        {
            var animalDto = await _getAnimalByIdSer.GetAnimalByIdAsync(id);

            if (animalDto == null)
                return NotFound();

            return Ok(animalDto);
        }

        // PUT: api/Animals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimal(int id, AnimalUpdateDTO dto)
        {
            var success = await _animalToUpdateSer.UpdateAnimalAsync(id, dto);

            if (!success)
                return NotFound();

            return NoContent();
        }

            // POST: api/Animals
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
        public async Task<ActionResult<AnimalDTO>> PostAnimal(AnimalDTO animalDto)
        {
            Animal animal = await _animalService.CreateNewAnimalAsync(_animalRepository.AnimalMappper(animalDto));

            return CreatedAtAction("GetAnimal", new { id = animal.Id }, animal);
        }

        // DELETE: api/Animals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var deleted = await _animalDelete.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }

        private bool AnimalExists(int id)
        {
            return _context.Animals.Any(e => e.Id == id);
        }
    }
}
