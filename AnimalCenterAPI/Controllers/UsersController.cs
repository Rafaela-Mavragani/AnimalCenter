using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
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
    public class UsersController(AnimalAppDbContext context, IUserService userService, IUserRepository userRepository, IGetUserByIdSer getUserByIdSer) : ControllerBase
    {
        private readonly AnimalAppDbContext _context = context;
        private readonly IUserService _userService = userService;
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IGetUserByIdSer _getUserByIdSer = getUserByIdSer;

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var UserDto = await _getUserByIdSer.GetUserByIdAsync(id);

            if (UserDto == null)
                return NotFound();

            return Ok(UserDto);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<UserDTO>> PostUser(UserDTO userDTO)
        {
            User user = await _userService.CreateNewUserAsync(_userRepository.UserMappper(userDTO));

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
