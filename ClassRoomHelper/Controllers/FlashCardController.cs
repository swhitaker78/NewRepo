using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashCardController : ControllerBase
    {
        private readonly Context _context;
        public FlashCardController(Context context) => _context = context;
        [HttpGet]
        public async Task<IEnumerable<FlashCard>> GetflashCard() =>
         await _context.FlashCards.ToListAsync();
        [HttpGet("FlashCardID")]
        public async Task<IActionResult> GetFlashCardByID(int id)
        {
            var flashCard = await _context.FlashCards.FindAsync(id);
            return flashCard == null ? NotFound() : Ok(flashCard);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddFlashCard(FlashCard flashCard)
        {
            await _context.FlashCards.AddAsync(flashCard);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetFlashCardByID), new { id = flashCard }, flashCard);
        }
    }
}
