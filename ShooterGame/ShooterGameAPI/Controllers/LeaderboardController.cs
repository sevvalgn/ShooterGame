using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShooterGameAPI.Module;
using ShooterGameAPI.Data;
namespace ShooterGameAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeaderboardController : ControllerBase
    {
        private readonly GameDbContext db;
        public LeaderboardController(GameDbContext _db)
        {
            db = _db;
        }

        [HttpGet("{limit}")]
        public ActionResult<IEnumerable<Leaderboard>> GetLeaderboard(int limit)
        {
            if(db.leaderboard == null)
            {
                return NoContent();
            }
            return Ok(db.leaderboard.OrderByDescending(p => p.Score).Take(limit).ToList());
        }

        [HttpPost]

        public async Task<ActionResult<Leaderboard>> AddPlayer(Leaderboard player)
        {
            if (player == null)
            {
                return BadRequest();
            }
            var existingPlayer = db.leaderboard.FirstOrDefault(p => p.Name == player.Name && p.CharacterType == player.CharacterType);
            if (existingPlayer != null)
            {
                return Conflict();
            }
            if(player.CharacterType != "Fairy" && player.CharacterType != "Soldier" && player.CharacterType != "OldMan")
            {
                return BadRequest();
            }
            if (player.Score < 0)
            {
                return BadRequest();
            }
            db.leaderboard.Add(player);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Leaderboard>> UpdatePlayer(Leaderboard player)
        {
            var currentPlayer = db.leaderboard.FirstOrDefault(p => p.Name == player.Name && p.CharacterType == player.CharacterType);

            if (currentPlayer == null)
            {
                return NotFound();
            }
            if (player.Score < 0)
            {
                return BadRequest();
            }
            if(currentPlayer.Score > player.Score)
            {
                return BadRequest();
            }
            currentPlayer.Score = player.Score;
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
