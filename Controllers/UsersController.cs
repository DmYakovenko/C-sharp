using CRUD.Models;
using CRUD.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }

       
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

       
        [HttpPost]
        public ActionResult CreateUser([FromBody] User user)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, [FromBody] User user)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            var existingUser = _userService.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            user.Id = id;
            _userService.UpdateUser(user);
            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
