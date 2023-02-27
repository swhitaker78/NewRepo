using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly Context _context;
        public UserController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<Users>> GetcurrUser() =>
         await _context.Users.ToListAsync();
        [HttpGet("UserID")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            var currUser = await _context.Users.FindAsync(id);
            return currUser == null ? NotFound() : Ok(currUser);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddUser(Users currUser)
        {
            await _context.Users.AddAsync(currUser);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUserByID), new { id = currUser }, currUser);
        }
    }
}
