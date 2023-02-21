using ClassRoomHelper.Data;
using ClassRoomHelper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassRoomHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly Context _context;
        public ClassesController(Context context) => _context = context;
         
        public async Task<IEnumerable<Subject>> GetClasses =>
         await _context.Subjects.ToListAsync();
    }
}
