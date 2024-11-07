using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackend.Data;
using MyBackend.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeaderboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaderboardEntry>>> GetLeaderboardEntries()
        {
            return await _context.LeaderboardEntries
                .OrderByDescending(e => e.PlayerScore)
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<LeaderboardEntry>> PostLeaderboardEntry(LeaderboardEntry entry)
        {
            _context.LeaderboardEntries.Add(entry);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLeaderboardEntries), new { id = entry.PlayerId }, entry);
        }
    }
}
