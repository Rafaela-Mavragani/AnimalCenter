using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Enums;

namespace AnimalCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(AnimalAppDbContext context) : ControllerBase
    {
        private readonly AnimalAppDbContext _context = context;

        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login([FromBody] LoginDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.UserName) || string.IsNullOrWhiteSpace(dto.Password))
            {
                return BadRequest("Username and password are required.");
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == dto.UserName && u.Password == dto.Password);

            if (user == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            var userDto = new UserDTO
            {
                UserName = user.UserName,
                UserRole = user.UserRole
            };

            return Ok(userDto);
        }
    }
}
