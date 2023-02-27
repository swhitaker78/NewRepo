using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ClassRoomHelper.Controllers
{
    public class AnswersController : ControllerBase
    {
        private readonly Context _context;
        public AnswersController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<Answers>> Getanswers() =>
         await _context.Answers.ToListAsync();
        [HttpGet("AnswerID")]
        public async Task<IActionResult> GetAnswerByID(int id)
        {
            var answer = await _context.Answers.FindAsync(id);
            return answer == null ? NotFound() : Ok(answer);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddAnswer(Answers answer)
        {
            await _context.Answers.AddAsync(answer);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAnswerByID), new { id = answer }, answer);
        }

    }
}
