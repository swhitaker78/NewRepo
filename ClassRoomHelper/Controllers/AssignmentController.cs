using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly Context _context;
        public AssignmentController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<Assignment>> Getassignment() =>
         await _context.Assignments.ToListAsync();
        [HttpGet("AssignmentID")]
        public async Task<IActionResult> GetAssignmentByID(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            return assignment == null ? NotFound() : Ok(assignment);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddAssignment(Assignment assignment)
        {
            await _context.Assignments.AddAsync(assignment);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAssignmentByID), new { id = assignment }, assignment);
        }
    }
}
