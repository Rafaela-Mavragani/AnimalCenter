using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Exceptions;
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
    public class AnimalsController(AnimalAppDbContext context,IAnimalService animalService , IAnimalToUpdateSer animalToUpdateSer, IAnimalRepository animalRepository) : ControllerBase
    {
        private readonly AnimalAppDbContext _context = context;
    
        private readonly IAnimalService _animalService = animalService;

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
            var animalDto = await _animalService.GetAnimalByIdAsync(id) ?? throw new EntityNotFoundException("Animal ", $"with ID: {id}");

            

            return Ok(animalDto);
        }

        // PUT: api/Animals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimal(int id, AnimalUpdateDTO dto)
        {
            var success = await _animalToUpdateSer.UpdateAnimalAsync(id, dto);

            if (!success)
                throw new EntityNotFoundException("Animal", $"with ID: {id}");

            return NoContent();
        }

       
        [HttpPost]
        public async Task<ActionResult<AnimalDTO>> PostAnimal(AnimalDTO animalDto)
        {
            bool exists = await _context.Animals.AnyAsync(x => x.Id == animalDto.Id); 

            if (exists)
            {
                throw new EntityAlreadyExistsException("Animal", $"with Id: {animalDto.Id}"); 
            }

            Animal animal = await _animalService.CreateNewAnimalAsync(_animalRepository.AnimalMappper(animalDto));

            return CreatedAtAction("GetAnimal", new { id = animal.Id }, animal);
        }

        // DELETE: api/Animals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var deleted = await _animalService.DeleteAsync(id);

            if (!deleted)
                throw new EntityAlreadyExistsException("Animal", $"with Id: {id}"); 

            return NoContent();
        }

     
    }
}
