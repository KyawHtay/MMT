using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MMT.interfaces;
using MMT.Models;

namespace MMT.Controllers
{
    public class UsersController: BaseApiController
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _userRepository.GetUsersAsync();
            return Ok(users);
        }
         [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetUser(string email)
        {
           return await _userRepository.GetUserAsync(email);
            
        }
        
    }
}