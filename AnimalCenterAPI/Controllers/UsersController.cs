﻿using AnimalCenterAPI.Data;
using AnimalCenterAPI.DTO;
using AnimalCenterAPI.Exceptions;
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
    public class UsersController(AnimalAppDbContext context, IUserService userService, IUserRepository userRepository) : ControllerBase
    {
        private readonly AnimalAppDbContext _context = context;
        private readonly IUserService _userService = userService;
        private readonly IUserRepository _userRepository = userRepository;
    

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
            var UserDto = await _userService.GetUserByIdAsync(id) ?? throw new EntityNotFoundException("User", $"with ID: {id}");

           

            return Ok(UserDto);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<UserDTO>> PostUser(UserDTO userDTO)
        {
            bool exists = await _context.Users.AnyAsync(x => x.Id == userDTO.Id);

            if (exists)
            {
                throw new EntityAlreadyExistsException("User", $"with Id: {userDTO.Id}");
            }
            User user = await _userService.CreateNewUserAsync(_userRepository.UserMappper(userDTO));

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }


        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deleted = await _userService.DeleteAsync(id);

            if (!deleted)
                throw new EntityAlreadyExistsException("User", $"with Id: {id}");

            return NoContent();
        }

    }
}
