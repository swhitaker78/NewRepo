using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly Context _context;
        public QuestionController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<Question>> Getquestion() =>
         await _context.Questions.ToListAsync();
        [HttpGet("QuestionID")]
        public async Task<IActionResult> GetQuestionByID(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            return question == null ? NotFound() : Ok(question);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddQuestion(Question question)
        {
            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetQuestionByID), new { id = question }, question);
        }
    }
}
