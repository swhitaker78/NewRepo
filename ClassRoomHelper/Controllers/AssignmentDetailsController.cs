using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentDetailsController : ControllerBase
    {
        private readonly Context _context;
        public AssignmentDetailsController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<AssignmentDetails>> GetAssignmentDetails() =>
         await _context.AssignmentDetails.ToListAsync();
        [HttpGet("AssignmentDetailsID")]
        public async Task<IActionResult> GetAssignmentDetailsByID(int id)
        {
            var assignmentDetail = await _context.AssignmentDetails.FindAsync(id);
            return assignmentDetail == null ? NotFound() : Ok(assignmentDetail);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddAssignmentDetails(AssignmentDetails assignmentDetail)
        {
            await _context.AssignmentDetails.AddAsync(assignmentDetail);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAssignmentDetailsByID), new { id = assignmentDetail }, assignmentDetail);
        }
    }
}

