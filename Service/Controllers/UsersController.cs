using Microsoft.AspNetCore.Mvc;
using ServiceDataLayer.Models;
using ServiceDataLayer.Models.DTOs;
using ServiceDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsersAsync();
            var userDTOs = users.Select(user => new UserDTO
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.Phone
            }).ToList();

            return Ok(userDTOs);
        }

        // GET: api/Users/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUserById(Guid id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userDTO = new UserDTO
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Phone = user.Phone
            };

            return Ok(userDTO);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<UserDTO>> AddUser(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return BadRequest();
            }

            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = userDTO.Username,
                Password = userDTO.Password,
                Name = userDTO.Name,
                Surname = userDTO.Surname,
                Email = userDTO.Email,
                Phone = userDTO.Phone
            };

            var createdUser = await _userRepository.AddUserAsync(user);
            var createdUserDTO = new UserDTO
            {
                Id = createdUser.Id,
                Username = createdUser.Username,
                Password = userDTO.Password,
                Name = createdUser.Name,
                Surname = createdUser.Surname,
                Email = createdUser.Email,
                Phone = createdUser.Phone
            };

            return CreatedAtAction(nameof(GetUserById), new { id = createdUserDTO.Id }, createdUserDTO);
        }

        // PUT: api/Users/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, UserDTO userDTO)
        {
            if (id != userDTO.Id)
            {
                return BadRequest();
            }

            var user = new User
            {
                Id = userDTO.Id,
                Username = userDTO.Username,
                Password = userDTO.Password,
                Name = userDTO.Name,
                Surname = userDTO.Surname,
                Email = userDTO.Email,
                Phone = userDTO.Phone
            };

            var updatedUser = await _userRepository.UpdateUserAsync(user);
            if (updatedUser == null)
            {
                return NotFound();
            }

            var updatedUserDTO = new UserDTO
            {
                Id = updatedUser.Id,
                Username = updatedUser.Username,
                Password = updatedUser.Password,
                Name = updatedUser.Name,
                Surname = updatedUser.Surname,
                Email = updatedUser.Email,
                Phone = updatedUser.Phone
            };

            return Ok(updatedUserDTO);
        }

        // DELETE: api/Users/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = await _userRepository.DeleteUserAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
