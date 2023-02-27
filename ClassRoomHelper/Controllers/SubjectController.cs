using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly Context _context;
        public SubjectController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<Subject>> GetSubjects() =>
         await _context.Subjects.ToListAsync();
        [HttpGet("SubjectID")]
        public async Task<IActionResult> GetSubjectByID(int id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            return subject == null ? NotFound() : Ok(subject);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddSubject(Subject subject)
        {
            await _context.Subjects.AddAsync(subject);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSubjectByID), new { id = subject.SubjectID }, subject);
        }

    }
}
