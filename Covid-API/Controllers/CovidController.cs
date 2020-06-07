using Covid_API.Models;
using Covid_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CovidController : ControllerBase
    {
        private readonly UserService userService = new UserService();

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string docPath)
        {
            return await userService.GetUser(docPath);; 
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await userService.GetUsers();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStock(string docPath, User user)
        {
            await userService.SetUser(docPath, user);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostUser(User user)
        {
            await userService.AddUser(user);
            return CreatedAtAction("GetUser", new { id = user.userId }, user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUSer(string docPath)
        {
            await userService.DeleteUser(docPath);
            return Ok();
        }
    }
}
